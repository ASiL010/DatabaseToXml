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
            this.CombineALL = new System.Windows.Forms.CheckBox();
            this.author = new System.Windows.Forms.LinkLabel();
            this.XmlMergeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KaydetBasla
            // 
            this.KaydetBasla.Enabled = false;
            this.KaydetBasla.Location = new System.Drawing.Point(199, 133);
            this.KaydetBasla.Name = "KaydetBasla";
            this.KaydetBasla.Size = new System.Drawing.Size(301, 219);
            this.KaydetBasla.TabIndex = 0;
            this.KaydetBasla.Text = "Satış Siparişlerini, Cari Hesapları ve Malzemeleri Kaydet";
            this.KaydetBasla.UseVisualStyleBackColor = true;
            this.KaydetBasla.Click += new System.EventHandler(this.KaydetBasla_Clk);
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
            // CombineALL
            // 
            this.CombineALL.AutoSize = true;
            this.CombineALL.Location = new System.Drawing.Point(255, 283);
            this.CombineALL.Name = "CombineALL";
            this.CombineALL.Size = new System.Drawing.Size(194, 20);
            this.CombineALL.TabIndex = 3;
            this.CombineALL.Text = "Seçiliyken her şeyi birleştirir";
            this.CombineALL.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.XmlMergeButton);
            this.Controls.Add(this.author);
            this.Controls.Add(this.KaydetBasla);
            this.Controls.Add(this.CombineALL);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Database exports to Xml";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KaydetBasla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CombineALL;
        private System.Windows.Forms.LinkLabel author;
        private System.Windows.Forms.Button XmlMergeButton;
    }
}

