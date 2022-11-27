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
            this.KaydetBasla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.LinkLabel();
            this.XmlMergeButton = new System.Windows.Forms.Button();
            this.OrderBox = new System.Windows.Forms.CheckBox();
            this.SelectedOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BüyükDate = new System.Windows.Forms.DateTimePicker();
            this.KüçükDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SecilenPanelineGit = new System.Windows.Forms.Button();
            this.Pnl_secilenSiparis = new System.Windows.Forms.Panel();
            this.OncekineDon = new System.Windows.Forms.Button();
            this.SecilenIleKaydet_btn = new System.Windows.Forms.Button();
            this.Pnl_secilenSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // KaydetBasla
            // 
            this.KaydetBasla.Location = new System.Drawing.Point(6, 97);
            this.KaydetBasla.Name = "KaydetBasla";
            this.KaydetBasla.Size = new System.Drawing.Size(223, 219);
            this.KaydetBasla.TabIndex = 0;
            this.KaydetBasla.Text = "Satış Siparişlerini, Cari Hesapları ve Malzemeleri Kaydet";
            this.KaydetBasla.UseVisualStyleBackColor = true;
            this.KaydetBasla.Click += new System.EventHandler(this.KaydetBasla_Clk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kaydedilecek Yeri Seciniz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.KaydetmeYeri_Clk);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(3, 389);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(85, 16);
            this.author.TabIndex = 5;
            this.author.TabStop = true;
            this.author.Text = "Made by Asil";
            this.author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.author_LinkClicked);
            // 
            // XmlMergeButton
            // 
            this.XmlMergeButton.Enabled = false;
            this.XmlMergeButton.Location = new System.Drawing.Point(685, 10);
            this.XmlMergeButton.Name = "XmlMergeButton";
            this.XmlMergeButton.Size = new System.Drawing.Size(182, 43);
            this.XmlMergeButton.TabIndex = 6;
            this.XmlMergeButton.Text = "Birleştiriciyi Aç";
            this.XmlMergeButton.UseVisualStyleBackColor = true;
            this.XmlMergeButton.Visible = false;
            this.XmlMergeButton.Click += new System.EventHandler(this.XmlMerger_Clk);
            // 
            // OrderBox
            // 
            this.OrderBox.AutoSize = true;
            this.OrderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrderBox.ForeColor = System.Drawing.Color.White;
            this.OrderBox.Location = new System.Drawing.Point(685, 119);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(270, 20);
            this.OrderBox.TabIndex = 12;
            this.OrderBox.Text = "Sipariş numarası yazılıyken seçiniz";
            this.OrderBox.UseVisualStyleBackColor = true;
            this.OrderBox.Visible = false;
            // 
            // SelectedOrderNumber
            // 
            this.SelectedOrderNumber.Location = new System.Drawing.Point(22, 147);
            this.SelectedOrderNumber.Name = "SelectedOrderNumber";
            this.SelectedOrderNumber.Size = new System.Drawing.Size(394, 22);
            this.SelectedOrderNumber.TabIndex = 13;
            this.SelectedOrderNumber.TextChanged += new System.EventHandler(this.SelectedOrderNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seçilen Sipariş Numarası";
            // 
            // BüyükDate
            // 
            this.BüyükDate.CustomFormat = "";
            this.BüyükDate.Location = new System.Drawing.Point(97, 49);
            this.BüyükDate.Name = "BüyükDate";
            this.BüyükDate.Size = new System.Drawing.Size(207, 22);
            this.BüyükDate.TabIndex = 15;
            // 
            // KüçükDate
            // 
            this.KüçükDate.Location = new System.Drawing.Point(98, 18);
            this.KüçükDate.Name = "KüçükDate";
            this.KüçükDate.Size = new System.Drawing.Size(206, 22);
            this.KüçükDate.TabIndex = 16;
            this.KüçükDate.Value = new System.DateTime(2022, 11, 27, 16, 50, 0, 0);
            this.KüçükDate.ValueChanged += new System.EventHandler(this.KüçükDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Başlangıç : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bitiş : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 322);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(454, 34);
            this.progressBar1.TabIndex = 19;
            // 
            // SecilenPanelineGit
            // 
            this.SecilenPanelineGit.Location = new System.Drawing.Point(247, 97);
            this.SecilenPanelineGit.Name = "SecilenPanelineGit";
            this.SecilenPanelineGit.Size = new System.Drawing.Size(213, 219);
            this.SecilenPanelineGit.TabIndex = 20;
            this.SecilenPanelineGit.Text = "Tek Sipariş Getir";
            this.SecilenPanelineGit.UseVisualStyleBackColor = true;
            this.SecilenPanelineGit.Click += new System.EventHandler(this.SecilenPanelineGit_Click);
            // 
            // Pnl_secilenSiparis
            // 
            this.Pnl_secilenSiparis.BackColor = System.Drawing.Color.Turquoise;
            this.Pnl_secilenSiparis.Controls.Add(this.OncekineDon);
            this.Pnl_secilenSiparis.Controls.Add(this.SecilenIleKaydet_btn);
            this.Pnl_secilenSiparis.Controls.Add(this.SelectedOrderNumber);
            this.Pnl_secilenSiparis.Controls.Add(this.label2);
            this.Pnl_secilenSiparis.Location = new System.Drawing.Point(6, 7);
            this.Pnl_secilenSiparis.Name = "Pnl_secilenSiparis";
            this.Pnl_secilenSiparis.Size = new System.Drawing.Size(454, 309);
            this.Pnl_secilenSiparis.TabIndex = 21;
            this.Pnl_secilenSiparis.Visible = false;
            // 
            // OncekineDon
            // 
            this.OncekineDon.Location = new System.Drawing.Point(241, 188);
            this.OncekineDon.Name = "OncekineDon";
            this.OncekineDon.Size = new System.Drawing.Size(175, 118);
            this.OncekineDon.TabIndex = 16;
            this.OncekineDon.Text = "Önceki Ekrana Dön";
            this.OncekineDon.UseVisualStyleBackColor = true;
            this.OncekineDon.Click += new System.EventHandler(this.OncekineDon_Click);
            // 
            // SecilenIleKaydet_btn
            // 
            this.SecilenIleKaydet_btn.Location = new System.Drawing.Point(22, 188);
            this.SecilenIleKaydet_btn.Name = "SecilenIleKaydet_btn";
            this.SecilenIleKaydet_btn.Size = new System.Drawing.Size(213, 118);
            this.SecilenIleKaydet_btn.TabIndex = 15;
            this.SecilenIleKaydet_btn.Text = "Cari Sipariş ve Malzemeyi Getir";
            this.SecilenIleKaydet_btn.UseVisualStyleBackColor = true;
            this.SecilenIleKaydet_btn.Click += new System.EventHandler(this.SecilenIleKaydet_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1024, 567);
            this.Controls.Add(this.Pnl_secilenSiparis);
            this.Controls.Add(this.SecilenPanelineGit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KüçükDate);
            this.Controls.Add(this.BüyükDate);
            this.Controls.Add(this.OrderBox);
            this.Controls.Add(this.XmlMergeButton);
            this.Controls.Add(this.author);
            this.Controls.Add(this.KaydetBasla);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Database exports to Xml";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnl_secilenSiparis.ResumeLayout(false);
            this.Pnl_secilenSiparis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KaydetBasla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel author;
        private System.Windows.Forms.Button XmlMergeButton;
        private System.Windows.Forms.CheckBox OrderBox;
        private System.Windows.Forms.TextBox SelectedOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BüyükDate;
        private System.Windows.Forms.DateTimePicker KüçükDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button SecilenPanelineGit;
        private System.Windows.Forms.Panel Pnl_secilenSiparis;
        private System.Windows.Forms.Button SecilenIleKaydet_btn;
        private System.Windows.Forms.Button OncekineDon;
    }
}

