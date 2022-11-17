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
            this.CariRadio = new System.Windows.Forms.RadioButton();
            this.SatısRadio = new System.Windows.Forms.RadioButton();
            this.MalzemeRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderBox = new System.Windows.Forms.CheckBox();
            this.SelectedOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BüyükDate = new System.Windows.Forms.DateTimePicker();
            this.KüçükDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KaydetBasla
            // 
            this.KaydetBasla.Enabled = false;
            this.KaydetBasla.Location = new System.Drawing.Point(330, 128);
            this.KaydetBasla.Name = "KaydetBasla";
            this.KaydetBasla.Size = new System.Drawing.Size(223, 219);
            this.KaydetBasla.TabIndex = 0;
            this.KaydetBasla.Text = "Satış Siparişlerini, Cari Hesapları ve Malzemeleri Kaydet";
            this.KaydetBasla.UseVisualStyleBackColor = true;
            this.KaydetBasla.Click += new System.EventHandler(this.KaydetBasla_Clk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kaydedilecek Yeri Seciniz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.KaydetmeYeri_Clk);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(13, 432);
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
            this.XmlMergeButton.Location = new System.Drawing.Point(579, 36);
            this.XmlMergeButton.Name = "XmlMergeButton";
            this.XmlMergeButton.Size = new System.Drawing.Size(182, 43);
            this.XmlMergeButton.TabIndex = 6;
            this.XmlMergeButton.Text = "Birleştiriciyi Aç";
            this.XmlMergeButton.UseVisualStyleBackColor = true;
            this.XmlMergeButton.Click += new System.EventHandler(this.XmlMerger_Clk);
            // 
            // CariRadio
            // 
            this.CariRadio.AutoSize = true;
            this.CariRadio.Location = new System.Drawing.Point(28, 18);
            this.CariRadio.Name = "CariRadio";
            this.CariRadio.Size = new System.Drawing.Size(99, 20);
            this.CariRadio.TabIndex = 7;
            this.CariRadio.TabStop = true;
            this.CariRadio.Text = "Cari Kayıtlar";
            this.CariRadio.UseVisualStyleBackColor = true;
            // 
            // SatısRadio
            // 
            this.SatısRadio.AutoSize = true;
            this.SatısRadio.Location = new System.Drawing.Point(28, 44);
            this.SatısRadio.Name = "SatısRadio";
            this.SatısRadio.Size = new System.Drawing.Size(121, 20);
            this.SatısRadio.TabIndex = 8;
            this.SatısRadio.TabStop = true;
            this.SatısRadio.Text = "Satış Siparişleri";
            this.SatısRadio.UseVisualStyleBackColor = true;
            // 
            // MalzemeRadio
            // 
            this.MalzemeRadio.AutoSize = true;
            this.MalzemeRadio.Location = new System.Drawing.Point(28, 70);
            this.MalzemeRadio.Name = "MalzemeRadio";
            this.MalzemeRadio.Size = new System.Drawing.Size(98, 20);
            this.MalzemeRadio.TabIndex = 9;
            this.MalzemeRadio.TabStop = true;
            this.MalzemeRadio.Text = "Malzemeler";
            this.MalzemeRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MalzemeRadio);
            this.groupBox1.Controls.Add(this.CariRadio);
            this.groupBox1.Controls.Add(this.SatısRadio);
            this.groupBox1.Location = new System.Drawing.Point(545, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birleştirme ismi Seçmek için kullanınız";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Not: Sadece ismi belirler";
            // 
            // OrderBox
            // 
            this.OrderBox.AutoSize = true;
            this.OrderBox.Location = new System.Drawing.Point(16, 169);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(235, 20);
            this.OrderBox.TabIndex = 12;
            this.OrderBox.Text = "Sipariş numarası yazılıyken seçiniz";
            this.OrderBox.UseVisualStyleBackColor = true;
            // 
            // SelectedOrderNumber
            // 
            this.SelectedOrderNumber.Location = new System.Drawing.Point(16, 141);
            this.SelectedOrderNumber.Name = "SelectedOrderNumber";
            this.SelectedOrderNumber.Size = new System.Drawing.Size(235, 22);
            this.SelectedOrderNumber.TabIndex = 13;
            this.SelectedOrderNumber.TextChanged += new System.EventHandler(this.SelectedOrderNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seçilen Sipariş Numarası";
            // 
            // BüyükDate
            // 
            this.BüyükDate.CustomFormat = "";
            this.BüyükDate.Location = new System.Drawing.Point(164, 36);
            this.BüyükDate.Name = "BüyükDate";
            this.BüyükDate.Size = new System.Drawing.Size(163, 22);
            this.BüyükDate.TabIndex = 15;
            this.BüyükDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // KüçükDate
            // 
            this.KüçükDate.Location = new System.Drawing.Point(6, 36);
            this.KüçükDate.Name = "KüçükDate";
            this.KüçükDate.Size = new System.Drawing.Size(149, 22);
            this.KüçükDate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Başlangıç : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bitiş : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KüçükDate);
            this.Controls.Add(this.BüyükDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedOrderNumber);
            this.Controls.Add(this.OrderBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.XmlMergeButton);
            this.Controls.Add(this.author);
            this.Controls.Add(this.KaydetBasla);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Database exports to Xml";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KaydetBasla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel author;
        private System.Windows.Forms.Button XmlMergeButton;
        private System.Windows.Forms.RadioButton CariRadio;
        private System.Windows.Forms.RadioButton SatısRadio;
        private System.Windows.Forms.RadioButton MalzemeRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox OrderBox;
        private System.Windows.Forms.TextBox SelectedOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BüyükDate;
        private System.Windows.Forms.DateTimePicker KüçükDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

