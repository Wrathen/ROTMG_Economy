using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RotMG_Economy
{
    public partial class Form1 : Form
    {
        public static string path;
        public static string path_WebCrawl;
        public static string adress = "https://www.realmeye.com/offers-to/";
        public static List<int> checkedItems_Sell = new List<int>();
        public static List<int> checkedItems_Buy = new List<int>();

        public enum OfferType
        {
            SELL,
            BUY
        }
        public Form1()
        {
            InitializeComponent();
            path = txt_PathItemDB.Text;
            path_WebCrawl = txt_WebCrawl.Text;
            timer1.Interval = 100;
            timer1.Start();
        }
        private void But_GetOffers_Click(object sender, EventArgs e)
        {
            Offer[] allOffers = radio_Buy.Checked ? GetOffers(Convert.ToInt32(txt_ItemID.Text), OfferType.BUY) : GetOffers(Convert.ToInt32(txt_ItemID.Text), OfferType.SELL);
            WriteToFile(path, allOffers);
        }
        private void but_OfferCrawl_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(WebCrawl));
            thread.Start();
        }
        public void WebCrawl()
        {
            WebCrawl(Convert.ToInt32(txt_ItemID.Text));
        }
        public void WebCrawl(int startingID)
        {
            Offer[] allOffersSell = GetOffers(startingID, OfferType.SELL);
            Offer[] allOffersBuy = GetOffers(startingID, OfferType.BUY);

            WriteToFile(path_WebCrawl + "/WebCrawl/Sell_" + Item.GetItemName(startingID) + ".txt", allOffersSell);
            WriteToFile(path_WebCrawl + "/WebCrawl/Buy_" + Item.GetItemName(startingID) + ".txt", allOffersBuy);

            for (int i = 0; i < allOffersSell.Length; i++)
            {
                foreach(Item iSell in allOffersSell[i].sellOffer)
                {
                    if(!checkedItems_Sell.Contains(iSell.ID))
                    {
                        checkedItems_Sell.Add(iSell.ID);
                        WebCrawl(iSell.ID);
                    }
                }
                foreach(Item iBuy in allOffersSell[i].buyOffer)
                {
                    if(!checkedItems_Buy.Contains(iBuy.ID))
                    {
                        checkedItems_Buy.Add(iBuy.ID);
                        WebCrawl(iBuy.ID);
                    }
                }
            }

            for (int i = 0; i < allOffersBuy.Length; i++)
            {
                foreach (Item iSell in allOffersBuy[i].sellOffer)
                {
                    if (!checkedItems_Sell.Contains(iSell.ID))
                    {
                        checkedItems_Sell.Add(iSell.ID);
                        WebCrawl(iSell.ID);
                    }
                }
                foreach (Item iBuy in allOffersBuy[i].buyOffer)
                {
                    if (!checkedItems_Buy.Contains(iBuy.ID))
                    {
                        checkedItems_Buy.Add(iBuy.ID);
                        WebCrawl(iBuy.ID);
                    }
                }
            }
        }
        public static void WriteToFile(string _path, Offer[] offers)
        {
            List<string> g = new List<string>();
            string sell = "";
            string buy = "";
            for (int i = 0; i < offers.Length; i++)
            {
                for (int j = 0; j < offers[i].sellOffer.Count; j++)
                {
                    sell += offers[i].sellOffer[j].Quantity + "x" + Item.GetItemName(offers[i].sellOffer[j].ID) + " ";
                }
                for (int k = 0; k < offers[i].buyOffer.Count; k++)
                {
                    buy += offers[i].buyOffer[k].Quantity + "x" + Item.GetItemName(offers[i].buyOffer[k].ID) + " ";
                }
                g.Add("[Sell] " + sell + " <-> [Buy] " + buy);
                sell = "";
                buy = "";
            }
            if (_path.Contains(":")) _path = _path.Replace(":", "-");
            if (_path.Contains("C-")) _path = _path.Replace("C-", "C:");
            _path = _path.Replace(" ", "");
            File.WriteAllLines(_path, g);
        }
        public static string GetHTML(string adress)
        {
            string data = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(adress);
            request.UseDefaultCredentials = true;
            request.UserAgent = "[somethin]";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            return data;
        }
        public static Offer[] GetOffers(int itemID, OfferType offerType)
        {
            string data = offerType == OfferType.SELL ? GetHTML(adress + "sell/" + itemID) : GetHTML(adress + "buy/" + itemID);
            int offerCount = GetHowManyOffers(data);
            Offer[] Offers = new Offer[offerCount];
            for(int i = 0; i < offerCount; i++)
            {
                Offers[i] = new Offer();
            }
            int currentOfferIndex = 0;
            string currentOfferItemID = "";
            string currentOfferItemQuantity = "";
            string searchItemID = "data-item=\"";
            bool fillSellOffers = true;
            int j = data.IndexOf("</tr>") + 5;

            for (; j < data.Length; j++)
            {
                if (data.Substring(j, 4) == "<tr>")
                {
                    fillSellOffers = true;
                    j += 4;
                }
                else if (data.Substring(j, 5) == "</tr>")
                {
                    currentOfferIndex++;
                    j += 5;
                }
                if (data.Substring(j, 5) == "</td>")
                {
                    j += 4;
                    fillSellOffers = !fillSellOffers;
                }
                if (j > data.Length - searchItemID.Length) break;

                if (data.Substring(j, searchItemID.Length) == searchItemID)
                {
                    for (int k = 0; ; k++)
                    {
                        if (data.Substring(j + searchItemID.Length + k, 1) == "\"") break;
                        currentOfferItemID = data.Substring(j + searchItemID.Length, k + 1);                        
                    }

                    j += searchItemID.Length + currentOfferItemID.Length + 45;
                    currentOfferItemQuantity = data.Substring(j, 1);
                    if (fillSellOffers) Offers[currentOfferIndex].sellOffer.Add(new Item(Convert.ToInt32(currentOfferItemID), Convert.ToInt32(currentOfferItemQuantity)));
                    else Offers[currentOfferIndex].buyOffer.Add(new Item(Convert.ToInt32(currentOfferItemID), Convert.ToInt32(currentOfferItemQuantity)));
                }
            }
            return Offers;
        }
        public static int GetHowManyOffers(string data)
        {
            string search = "<strong>";
            string searchEnd = "</strong>";
            string offerCount = "";
            for(int i = 0; i < data.Length; i++)
            {
                for(int j = 1; j < search.Length; j++)
                {
                    if (data.Substring(i, j) != search.Substring(0, j)) break;
                    if (j == search.Length - 1)
                    {
                        for(int k = 1; ; k++)
                        {
                            if (data.Substring(i + j + k, 1) == searchEnd.Substring(0, 1)) break;
                            offerCount = data.Substring(i + j + 1, k);
                        }
                    }
                    if (offerCount != "") return ConvertToNumber(offerCount);
                }
            }
            return ConvertToNumber(offerCount);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = checkedItems_Buy.Count.ToString();
            label3.Text = checkedItems_Sell.Count.ToString();
        }
        public static int ConvertToNumber(string str)
        {
            switch(str)
            {
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                case "ten":
                    return 10;
                case "eleven":
                    return 11;
                case "twelve":
                    return 12;
                case "thirteen":
                    return 13;
                case "fourteen":
                    return 14;
                case "fifteen":
                    return 15;
                default:
                    try { return Convert.ToInt32(str); }
                    catch (Exception e) { return 100; }                 
            }
        }
        private void but_PathChooseItemDB_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (fbd.SelectedPath.Substring(fbd.SelectedPath.Length - 4) != ".txt") fbd.SelectedPath += "/Database.txt";
                    txt_PathItemDB.Text = fbd.SelectedPath;
                    path = fbd.SelectedPath;
                    File.Create(path);
                }
            }
        }
        private void but_PathChooseWebCrawl_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txt_WebCrawl.Text = fbd.SelectedPath;
                    path_WebCrawl = fbd.SelectedPath;
                    if (!Directory.Exists(path_WebCrawl + "/WebCrawl")) Directory.CreateDirectory(path_WebCrawl + "/WebCrawl");
                }
            }
        }
    }
}