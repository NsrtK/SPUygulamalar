namespace FormDers2_2
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
            this.btnSayiUret = new System.Windows.Forms.Button();
            this.btnNotHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSayiUret
            // 
            this.btnSayiUret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSayiUret.Location = new System.Drawing.Point(137, 50);
            this.btnSayiUret.Name = "btnSayiUret";
            this.btnSayiUret.Size = new System.Drawing.Size(175, 75);
            this.btnSayiUret.TabIndex = 0;
            this.btnSayiUret.Text = "Sayı Üretme Oyunu";
            this.btnSayiUret.UseVisualStyleBackColor = true;
            this.btnSayiUret.Click += new System.EventHandler(this.btnSayiUret_Click);
            // 
            // btnNotHesapla
            // 
            this.btnNotHesapla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotHesapla.Location = new System.Drawing.Point(137, 192);
            this.btnNotHesapla.Name = "btnNotHesapla";
            this.btnNotHesapla.Size = new System.Drawing.Size(175, 75);
            this.btnNotHesapla.TabIndex = 0;
            this.btnNotHesapla.Text = "Not Hesaplama";
            this.btnNotHesapla.UseVisualStyleBackColor = true;
            this.btnNotHesapla.Click += new System.EventHandler(this.btnNotHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 332);
            this.Controls.Add(this.btnNotHesapla);
            this.Controls.Add(this.btnSayiUret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSayiUret;
        private Button btnNotHesapla;
    }
}