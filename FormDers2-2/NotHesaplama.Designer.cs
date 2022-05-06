namespace FormDers2_2
{
    partial class NotHesaplama
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
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxVize = new System.Windows.Forms.TextBox();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxKalan = new System.Windows.Forms.ListBox();
            this.listBoxGecen = new System.Windows.Forms.ListBox();
            this.buttonNotHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(302, 63);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(174, 23);
            this.textBoxAdSoyad.TabIndex = 0;
            // 
            // textBoxVize
            // 
            this.textBoxVize.Location = new System.Drawing.Point(100, 141);
            this.textBoxVize.Name = "textBoxVize";
            this.textBoxVize.Size = new System.Drawing.Size(100, 23);
            this.textBoxVize.TabIndex = 0;
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(536, 141);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(100, 23);
            this.textBoxFinal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Geçenler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kalanlar";
            // 
            // listBoxKalan
            // 
            this.listBoxKalan.FormattingEnabled = true;
            this.listBoxKalan.ItemHeight = 15;
            this.listBoxKalan.Location = new System.Drawing.Point(536, 258);
            this.listBoxKalan.Name = "listBoxKalan";
            this.listBoxKalan.Size = new System.Drawing.Size(203, 154);
            this.listBoxKalan.TabIndex = 2;
            // 
            // listBoxGecen
            // 
            this.listBoxGecen.FormattingEnabled = true;
            this.listBoxGecen.ItemHeight = 15;
            this.listBoxGecen.Location = new System.Drawing.Point(100, 258);
            this.listBoxGecen.Name = "listBoxGecen";
            this.listBoxGecen.Size = new System.Drawing.Size(203, 154);
            this.listBoxGecen.TabIndex = 2;
            // 
            // buttonNotHesapla
            // 
            this.buttonNotHesapla.Location = new System.Drawing.Point(302, 194);
            this.buttonNotHesapla.Name = "buttonNotHesapla";
            this.buttonNotHesapla.Size = new System.Drawing.Size(174, 23);
            this.buttonNotHesapla.TabIndex = 3;
            this.buttonNotHesapla.Text = "Hesapla";
            this.buttonNotHesapla.UseVisualStyleBackColor = true;
            this.buttonNotHesapla.Click += new System.EventHandler(this.buttonNotHesapla_Click);
            // 
            // NotHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNotHesapla);
            this.Controls.Add(this.listBoxGecen);
            this.Controls.Add(this.listBoxKalan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVize);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Name = "NotHesaplama";
            this.Text = "NotHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxAdSoyad;
        private TextBox textBoxVize;
        private TextBox textBoxFinal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBoxKalan;
        private ListBox listBoxGecen;
        private Button buttonNotHesapla;
    }
}