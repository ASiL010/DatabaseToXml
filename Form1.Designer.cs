namespace Gülsistem_V8.xml
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pnl_secilenSiparis.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KaydetBasla
            // 
            this.KaydetBasla.Location = new System.Drawing.Point(12, 102);
            this.KaydetBasla.Name = "KaydetBasla";
            this.KaydetBasla.Size = new System.Drawing.Size(351, 103);
            this.KaydetBasla.TabIndex = 0;
            this.KaydetBasla.Text = "DOSYALARI OLUŞTUR ve KAYDET";
            this.KaydetBasla.UseVisualStyleBackColor = true;
            this.KaydetBasla.Click += new System.EventHandler(this.KaydetBasla_Clk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kaydedilecek Yeri Seciniz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.KaydetmeYeri_Clk);
            // 
            // XmlMergeButton
            // 
            this.XmlMergeButton.Enabled = false;
            this.XmlMergeButton.Location = new System.Drawing.Point(27, 12);
            this.XmlMergeButton.Name = "XmlMergeButton";
            this.XmlMergeButton.Size = new System.Drawing.Size(159, 40);
            this.XmlMergeButton.TabIndex = 6;
            this.XmlMergeButton.Text = "Birleştiriciyi Aç";
            this.XmlMergeButton.UseVisualStyleBackColor = true;
            this.XmlMergeButton.Visible = false;
            this.XmlMergeButton.Click += new System.EventHandler(this.XmlMerger_Clk);
            // 
            // OrderBox
            // 
            this.OrderBox.AutoSize = true;
            this.OrderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderBox.ForeColor = System.Drawing.Color.White;
            this.OrderBox.Location = new System.Drawing.Point(27, 115);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(220, 17);
            this.OrderBox.TabIndex = 12;
            this.OrderBox.Text = "Sipariş numarası yazılıyken seçiniz";
            this.OrderBox.UseVisualStyleBackColor = true;
            this.OrderBox.Visible = false;
            // 
            // SelectedOrderNumber
            // 
            this.SelectedOrderNumber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SelectedOrderNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderNumber.Location = new System.Drawing.Point(39, 125);
            this.SelectedOrderNumber.Name = "SelectedOrderNumber";
            this.SelectedOrderNumber.Size = new System.Drawing.Size(325, 29);
            this.SelectedOrderNumber.TabIndex = 13;
            this.SelectedOrderNumber.TextChanged += new System.EventHandler(this.SelectedOrderNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sipariş Numarası Girin";
            // 
            // BüyükDate
            // 
            this.BüyükDate.CustomFormat = "";
            this.BüyükDate.Location = new System.Drawing.Point(92, 57);
            this.BüyükDate.Name = "BüyükDate";
            this.BüyükDate.Size = new System.Drawing.Size(182, 23);
            this.BüyükDate.TabIndex = 15;
            // 
            // KüçükDate
            // 
            this.KüçükDate.Location = new System.Drawing.Point(93, 28);
            this.KüçükDate.Name = "KüçükDate";
            this.KüçükDate.Size = new System.Drawing.Size(181, 23);
            this.KüçükDate.TabIndex = 16;
            this.KüçükDate.Value = new System.DateTime(2022, 11, 27, 16, 50, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(10, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Başlangıç : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bitiş : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 211);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 27);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // SecilenPanelineGit
            // 
            this.SecilenPanelineGit.Location = new System.Drawing.Point(280, 10);
            this.SecilenPanelineGit.Name = "SecilenPanelineGit";
            this.SecilenPanelineGit.Size = new System.Drawing.Size(106, 70);
            this.SecilenPanelineGit.TabIndex = 20;
            this.SecilenPanelineGit.Text = "Tek Sipariş Getir";
            this.SecilenPanelineGit.UseVisualStyleBackColor = true;
            this.SecilenPanelineGit.Click += new System.EventHandler(this.SecilenPanelineGit_Click);
            // 
            // Pnl_secilenSiparis
            // 
            this.Pnl_secilenSiparis.BackColor = System.Drawing.Color.Linen;
            this.Pnl_secilenSiparis.Controls.Add(this.OncekineDon);
            this.Pnl_secilenSiparis.Controls.Add(this.SecilenIleKaydet_btn);
            this.Pnl_secilenSiparis.Controls.Add(this.SelectedOrderNumber);
            this.Pnl_secilenSiparis.Controls.Add(this.label2);
            this.Pnl_secilenSiparis.Location = new System.Drawing.Point(1, -1);
            this.Pnl_secilenSiparis.Name = "Pnl_secilenSiparis";
            this.Pnl_secilenSiparis.Size = new System.Drawing.Size(425, 284);
            this.Pnl_secilenSiparis.TabIndex = 21;
            this.Pnl_secilenSiparis.Visible = false;
            // 
            // OncekineDon
            // 
            this.OncekineDon.Location = new System.Drawing.Point(0, 0);
            this.OncekineDon.Name = "OncekineDon";
            this.OncekineDon.Size = new System.Drawing.Size(102, 47);
            this.OncekineDon.TabIndex = 16;
            this.OncekineDon.Text = "Önceki Ekrana Dön";
            this.OncekineDon.UseVisualStyleBackColor = true;
            this.OncekineDon.Click += new System.EventHandler(this.OncekineDon_Click);
            // 
            // SecilenIleKaydet_btn
            // 
            this.SecilenIleKaydet_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecilenIleKaydet_btn.Location = new System.Drawing.Point(37, 186);
            this.SecilenIleKaydet_btn.Name = "SecilenIleKaydet_btn";
            this.SecilenIleKaydet_btn.Size = new System.Drawing.Size(323, 70);
            this.SecilenIleKaydet_btn.TabIndex = 15;
            this.SecilenIleKaydet_btn.Text = "Dosyaları Oluştur  ve Kaydet";
            this.SecilenIleKaydet_btn.UseVisualStyleBackColor = true;
            this.SecilenIleKaydet_btn.Click += new System.EventHandler(this.SecilenIleKaydet_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Satış Siparişlerini, Cari Hesapları ve Malzemeleri için  XML dosyaları";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Belgelerim\\LOGO_XML_FILES  klasörüne kaydedilecektir.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 97);
            this.panel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Açıklama:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.XmlMergeButton);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.OrderBox);
            this.panel2.Location = new System.Drawing.Point(459, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 140);
            this.panel2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(426, 375);
            this.Controls.Add(this.Pnl_secilenSiparis);
            this.Controls.Add(this.KaydetBasla);
            this.Controls.Add(this.BüyükDate);
            this.Controls.Add(this.KüçükDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SecilenPanelineGit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Database exports to Xml";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnl_secilenSiparis.ResumeLayout(false);
            this.Pnl_secilenSiparis.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KaydetBasla;
        private System.Windows.Forms.Button button2;
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
        private Label label1;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
    }
}

