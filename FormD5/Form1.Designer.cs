namespace FormD5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonGoster = new System.Windows.Forms.Button();
            this.buttonDosyaOlustur = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(86, 63);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 23);
            this.textBoxAd.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(86, 127);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(100, 23);
            this.textBoxSoyad.TabIndex = 1;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(218, 62);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 45);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonGoster
            // 
            this.buttonGoster.Location = new System.Drawing.Point(319, 63);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(75, 44);
            this.buttonGoster.TabIndex = 2;
            this.buttonGoster.Text = "Göster";
            this.buttonGoster.UseVisualStyleBackColor = true;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // buttonDosyaOlustur
            // 
            this.buttonDosyaOlustur.Location = new System.Drawing.Point(218, 126);
            this.buttonDosyaOlustur.Name = "buttonDosyaOlustur";
            this.buttonDosyaOlustur.Size = new System.Drawing.Size(75, 44);
            this.buttonDosyaOlustur.TabIndex = 2;
            this.buttonDosyaOlustur.Text = "Dosya Oluştur";
            this.buttonDosyaOlustur.UseVisualStyleBackColor = true;
            this.buttonDosyaOlustur.Click += new System.EventHandler(this.buttonDosyaOlustur_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(319, 126);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 44);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(445, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 259);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 326);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonDosyaOlustur);
            this.Controls.Add(this.buttonGoster);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxAd;
        private TextBox textBoxSoyad;
        private Button buttonEkle;
        private Button buttonGoster;
        private Button buttonDosyaOlustur;
        private Button buttonSil;
        private ListBox listBox1;
    }
}