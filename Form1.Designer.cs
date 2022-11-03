namespace DatabaseToXml
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CariKaydetBTN = new System.Windows.Forms.Button();
            this.SirketSahıs = new System.Windows.Forms.CheckBox();
            this.UrunKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 219);
            this.button1.TabIndex = 0;
            this.button1.Text = "Satış Siparişlerini, Cari Hesapları ve Malzemeleri Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.KaydetBasla_Clk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kaydedilecek Yeri Seciniz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.KaydetmeYeri_Clk);
            // 
            // CariKaydetBTN
            // 
            this.CariKaydetBTN.Location = new System.Drawing.Point(257, 228);
            this.CariKaydetBTN.Name = "CariKaydetBTN";
            this.CariKaydetBTN.Size = new System.Drawing.Size(207, 23);
            this.CariKaydetBTN.TabIndex = 2;
            this.CariKaydetBTN.Text = "Cari Hesapları Kaydet";
            this.CariKaydetBTN.UseVisualStyleBackColor = true;
            this.CariKaydetBTN.Click += new System.EventHandler(this.CariKaydetBTN_Clk);
            // 
            // SirketSahıs
            // 
            this.SirketSahıs.AutoSize = true;
            this.SirketSahıs.Location = new System.Drawing.Point(268, 279);
            this.SirketSahıs.Name = "SirketSahıs";
            this.SirketSahıs.Size = new System.Drawing.Size(187, 20);
            this.SirketSahıs.TabIndex = 3;
            this.SirketSahıs.Text = "Şahıs Şirketleri için Seçiniz";
            this.SirketSahıs.UseVisualStyleBackColor = true;
            // 
            // UrunKaydet
            // 
            this.UrunKaydet.Location = new System.Drawing.Point(290, 187);
            this.UrunKaydet.Name = "UrunKaydet";
            this.UrunKaydet.Size = new System.Drawing.Size(75, 23);
            this.UrunKaydet.TabIndex = 4;
            this.UrunKaydet.Text = "UrunKaydet";
            this.UrunKaydet.UseVisualStyleBackColor = true;
            this.UrunKaydet.Click += new System.EventHandler(this.UrunKaydet_Clk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UrunKaydet);
            this.Controls.Add(this.SirketSahıs);
            this.Controls.Add(this.CariKaydetBTN);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CariKaydetBTN;
        private System.Windows.Forms.CheckBox SirketSahıs;
        private System.Windows.Forms.Button UrunKaydet;
    }
}

