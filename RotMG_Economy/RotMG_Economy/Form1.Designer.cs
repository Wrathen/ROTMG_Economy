namespace RotMG_Economy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.But_GetOffers = new System.Windows.Forms.Button();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.but_OfferCrawl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_Buy = new System.Windows.Forms.RadioButton();
            this.radio_Sell = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PathItemDB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_WebCrawl = new System.Windows.Forms.TextBox();
            this.but_PathChooseItemDB = new System.Windows.Forms.Button();
            this.but_PathChooseWebCrawl = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // But_GetOffers
            // 
            this.But_GetOffers.Location = new System.Drawing.Point(38, 112);
            this.But_GetOffers.Name = "But_GetOffers";
            this.But_GetOffers.Size = new System.Drawing.Size(75, 42);
            this.But_GetOffers.TabIndex = 0;
            this.But_GetOffers.Text = "Write Offers To File";
            this.But_GetOffers.UseVisualStyleBackColor = true;
            this.But_GetOffers.Click += new System.EventHandler(this.But_GetOffers_Click);
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Location = new System.Drawing.Point(79, 41);
            this.txt_ItemID.MaxLength = 5;
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(75, 20);
            this.txt_ItemID.TabIndex = 1;
            this.txt_ItemID.Text = "2985";
            this.txt_ItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_OfferCrawl
            // 
            this.but_OfferCrawl.Location = new System.Drawing.Point(119, 112);
            this.but_OfferCrawl.Name = "but_OfferCrawl";
            this.but_OfferCrawl.Size = new System.Drawing.Size(75, 42);
            this.but_OfferCrawl.TabIndex = 4;
            this.but_OfferCrawl.Text = "Web Crawl All Offers";
            this.but_OfferCrawl.UseVisualStyleBackColor = true;
            this.but_OfferCrawl.Click += new System.EventHandler(this.but_OfferCrawl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item ID:";
            // 
            // radio_Buy
            // 
            this.radio_Buy.AutoSize = true;
            this.radio_Buy.Location = new System.Drawing.Point(38, 89);
            this.radio_Buy.Name = "radio_Buy";
            this.radio_Buy.Size = new System.Drawing.Size(57, 17);
            this.radio_Buy.TabIndex = 6;
            this.radio_Buy.Text = "Buying";
            this.radio_Buy.UseVisualStyleBackColor = true;
            // 
            // radio_Sell
            // 
            this.radio_Sell.AutoSize = true;
            this.radio_Sell.Checked = true;
            this.radio_Sell.Location = new System.Drawing.Point(39, 67);
            this.radio_Sell.Name = "radio_Sell";
            this.radio_Sell.Size = new System.Drawing.Size(56, 17);
            this.radio_Sell.TabIndex = 7;
            this.radio_Sell.TabStop = true;
            this.radio_Sell.Text = "Selling";
            this.radio_Sell.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Crawling Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Checked Items_Buy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Checked Items_Sell:";
            // 
            // txt_PathItemDB
            // 
            this.txt_PathItemDB.Location = new System.Drawing.Point(619, 187);
            this.txt_PathItemDB.Name = "txt_PathItemDB";
            this.txt_PathItemDB.Size = new System.Drawing.Size(100, 20);
            this.txt_PathItemDB.TabIndex = 13;
            this.txt_PathItemDB.Text = "C:/Users/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Locations";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Item Database Path:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Web Crawl Output Path:";
            // 
            // txt_WebCrawl
            // 
            this.txt_WebCrawl.Location = new System.Drawing.Point(619, 213);
            this.txt_WebCrawl.Name = "txt_WebCrawl";
            this.txt_WebCrawl.Size = new System.Drawing.Size(100, 20);
            this.txt_WebCrawl.TabIndex = 16;
            this.txt_WebCrawl.Text = "C:/Users/";
            // 
            // but_PathChooseItemDB
            // 
            this.but_PathChooseItemDB.Location = new System.Drawing.Point(725, 184);
            this.but_PathChooseItemDB.Name = "but_PathChooseItemDB";
            this.but_PathChooseItemDB.Size = new System.Drawing.Size(55, 23);
            this.but_PathChooseItemDB.TabIndex = 18;
            this.but_PathChooseItemDB.Text = "Choose";
            this.but_PathChooseItemDB.UseVisualStyleBackColor = true;
            this.but_PathChooseItemDB.Click += new System.EventHandler(this.but_PathChooseItemDB_Click);
            // 
            // but_PathChooseWebCrawl
            // 
            this.but_PathChooseWebCrawl.Location = new System.Drawing.Point(725, 211);
            this.but_PathChooseWebCrawl.Name = "but_PathChooseWebCrawl";
            this.but_PathChooseWebCrawl.Size = new System.Drawing.Size(55, 23);
            this.but_PathChooseWebCrawl.TabIndex = 19;
            this.but_PathChooseWebCrawl.Text = "Choose";
            this.but_PathChooseWebCrawl.UseVisualStyleBackColor = true;
            this.but_PathChooseWebCrawl.Click += new System.EventHandler(this.but_PathChooseWebCrawl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(76, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Credits @ MPGH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(9, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Idea: maxhunter2011";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(122, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Creator: Stacymom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(818, 370);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.but_PathChooseWebCrawl);
            this.Controls.Add(this.but_PathChooseItemDB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_WebCrawl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_PathItemDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio_Sell);
            this.Controls.Add(this.radio_Buy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_OfferCrawl);
            this.Controls.Add(this.txt_ItemID);
            this.Controls.Add(this.But_GetOffers);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Realm of The Mad God Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_GetOffers;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Button but_OfferCrawl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_Buy;
        private System.Windows.Forms.RadioButton radio_Sell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PathItemDB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_WebCrawl;
        private System.Windows.Forms.Button but_PathChooseItemDB;
        private System.Windows.Forms.Button but_PathChooseWebCrawl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

