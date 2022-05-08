namespace FormDers6
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
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelYas = new System.Windows.Forms.Label();
            this.labelSinif = new System.Windows.Forms.Label();
            this.labelOgrNo = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.textBoxyas = new System.Windows.Forms.TextBox();
            this.textBoxsinif = new System.Windows.Forms.TextBox();
            this.textBoxogrno = new System.Windows.Forms.TextBox();
            this.buttonKadGor = new System.Windows.Forms.Button();
            this.labelGoruntule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelAd.Location = new System.Drawing.Point(119, 60);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(30, 21);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "Ad";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelSoyad.Location = new System.Drawing.Point(119, 103);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(53, 21);
            this.labelSoyad.TabIndex = 0;
            this.labelSoyad.Text = "Soyad";
            // 
            // labelYas
            // 
            this.labelYas.AutoSize = true;
            this.labelYas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelYas.Location = new System.Drawing.Point(119, 149);
            this.labelYas.Name = "labelYas";
            this.labelYas.Size = new System.Drawing.Size(35, 21);
            this.labelYas.TabIndex = 0;
            this.labelYas.Text = "Yaş";
            // 
            // labelSinif
            // 
            this.labelSinif.AutoSize = true;
            this.labelSinif.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelSinif.Location = new System.Drawing.Point(119, 198);
            this.labelSinif.Name = "labelSinif";
            this.labelSinif.Size = new System.Drawing.Size(42, 21);
            this.labelSinif.TabIndex = 0;
            this.labelSinif.Text = "Sınıf";
            // 
            // labelOgrNo
            // 
            this.labelOgrNo.AutoSize = true;
            this.labelOgrNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelOgrNo.Location = new System.Drawing.Point(119, 243);
            this.labelOgrNo.Name = "labelOgrNo";
            this.labelOgrNo.Size = new System.Drawing.Size(94, 21);
            this.labelOgrNo.TabIndex = 0;
            this.labelOgrNo.Text = "Öğrenci NO";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(239, 61);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(100, 23);
            this.textBoxad.TabIndex = 1;
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(239, 103);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(100, 23);
            this.textBoxsoyad.TabIndex = 1;
            // 
            // textBoxyas
            // 
            this.textBoxyas.Location = new System.Drawing.Point(239, 141);
            this.textBoxyas.Name = "textBoxyas";
            this.textBoxyas.Size = new System.Drawing.Size(100, 23);
            this.textBoxyas.TabIndex = 1;
            // 
            // textBoxsinif
            // 
            this.textBoxsinif.Location = new System.Drawing.Point(239, 190);
            this.textBoxsinif.Name = "textBoxsinif";
            this.textBoxsinif.Size = new System.Drawing.Size(100, 23);
            this.textBoxsinif.TabIndex = 1;
            // 
            // textBoxogrno
            // 
            this.textBoxogrno.Location = new System.Drawing.Point(239, 235);
            this.textBoxogrno.Name = "textBoxogrno";
            this.textBoxogrno.Size = new System.Drawing.Size(100, 23);
            this.textBoxogrno.TabIndex = 1;
            // 
            // buttonKadGor
            // 
            this.buttonKadGor.Location = new System.Drawing.Point(444, 66);
            this.buttonKadGor.Name = "buttonKadGor";
            this.buttonKadGor.Size = new System.Drawing.Size(148, 98);
            this.buttonKadGor.TabIndex = 2;
            this.buttonKadGor.Text = "Kaydet ve Görüntüle";
            this.buttonKadGor.UseVisualStyleBackColor = true;
            this.buttonKadGor.Click += new System.EventHandler(this.buttonKadGor_Click);
            // 
            // labelGoruntule
            // 
            this.labelGoruntule.AutoSize = true;
            this.labelGoruntule.Location = new System.Drawing.Point(452, 243);
            this.labelGoruntule.Name = "labelGoruntule";
            this.labelGoruntule.Size = new System.Drawing.Size(17, 15);
            this.labelGoruntule.TabIndex = 3;
            this.labelGoruntule.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 334);
            this.Controls.Add(this.labelGoruntule);
            this.Controls.Add(this.buttonKadGor);
            this.Controls.Add(this.textBoxogrno);
            this.Controls.Add(this.textBoxsinif);
            this.Controls.Add(this.textBoxyas);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.labelOgrNo);
            this.Controls.Add(this.labelSinif);
            this.Controls.Add(this.labelYas);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAd;
        private Label labelSoyad;
        private Label labelYas;
        private Label labelSinif;
        private Label labelOgrNo;
        private TextBox textBoxad;
        private TextBox textBoxsoyad;
        private TextBox textBoxyas;
        private TextBox textBoxsinif;
        private TextBox textBoxogrno;
        private Button buttonKadGor;
        private Label labelGoruntule;
    }
}