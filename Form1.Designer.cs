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
            this.CombineALL = new System.Windows.Forms.CheckBox();
            this.author = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 133);
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
            // CombineALL
            // 
            this.CombineALL.AutoSize = true;
            this.CombineALL.Location = new System.Drawing.Point(533, 203);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.author);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CombineALL);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Database exports to Xml";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CombineALL;
        private System.Windows.Forms.LinkLabel author;
    }
}

