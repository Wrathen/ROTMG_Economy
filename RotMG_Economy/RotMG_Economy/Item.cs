using System;

namespace RotMG_Economy
{
    public class Item
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        
        public Item ()
        {
            ID = 0;
            Quantity = 0;
        }

        public Item (int ID, int Quantity)
        {
            this.ID = ID;
            this.Quantity = Quantity;
        }

        public static void AddToDatabase(int ID)
        {
            System.IO.File.AppendAllLines(Form1.path, new string[] { ID + ":" + GetItemName(ID) });
        }
        public static void AddToDatabase(int ID, string Name)
        {
            System.IO.File.AppendAllLines(Form1.path, new string[] { ID + ":" + Name });
        }
        public static string IsInDatabase(int ID)
        {
            string[] database = System.IO.File.ReadAllLines(Form1.path);

            foreach(string item in database)
            {
                if (ID == Convert.ToInt32(item.Substring(0, item.IndexOf(":")))) return item.Substring(item.IndexOf(":") + 1);
            }
            return "NO";
        }
        public static string GetItemName(int ID)
        {
            string isInDatabase = IsInDatabase(ID);
            if (isInDatabase != "NO") return isInDatabase;

            string data = Form1.GetHTML(Form1.adress + "buy/" + ID);
            string name = "";

            for (int i = 178; ; i++)
            {
                if (data.Substring(i, 1) == "?") break;
                name += data.Substring(i, 1);
            }
            AddToDatabase(ID, name);
            return name;
        }
    }
}