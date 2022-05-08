namespace FormD5
{
    partial class Form4
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
            this.labelbrs = new System.Windows.Forms.Label();
            this.labelfy = new System.Windows.Forms.Label();
            this.labelhs = new System.Windows.Forms.Label();
            this.textBoxHisse = new System.Windows.Forms.TextBox();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.textBoxBorsa = new System.Windows.Forms.TextBox();
            this.buttonGoruntule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelbrs
            // 
            this.labelbrs.AutoSize = true;
            this.labelbrs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelbrs.Location = new System.Drawing.Point(238, 194);
            this.labelbrs.Name = "labelbrs";
            this.labelbrs.Size = new System.Drawing.Size(52, 21);
            this.labelbrs.TabIndex = 2;
            this.labelbrs.Text = "Borsa";
            // 
            // labelfy
            // 
            this.labelfy.AutoSize = true;
            this.labelfy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelfy.Location = new System.Drawing.Point(238, 140);
            this.labelfy.Name = "labelfy";
            this.labelfy.Size = new System.Drawing.Size(47, 21);
            this.labelfy.TabIndex = 4;
            this.labelfy.Text = "Fiyat";
            // 
            // labelhs
            // 
            this.labelhs.AutoSize = true;
            this.labelhs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelhs.Location = new System.Drawing.Point(238, 88);
            this.labelhs.Name = "labelhs";
            this.labelhs.Size = new System.Drawing.Size(50, 21);
            this.labelhs.TabIndex = 6;
            this.labelhs.Text = "Hisse";
            // 
            // textBoxHisse
            // 
            this.textBoxHisse.Location = new System.Drawing.Point(357, 82);
            this.textBoxHisse.Name = "textBoxHisse";
            this.textBoxHisse.Size = new System.Drawing.Size(100, 23);
            this.textBoxHisse.TabIndex = 7;
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(357, 137);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(100, 23);
            this.textBoxFiyat.TabIndex = 7;
            // 
            // textBoxBorsa
            // 
            this.textBoxBorsa.Location = new System.Drawing.Point(357, 191);
            this.textBoxBorsa.Name = "textBoxBorsa";
            this.textBoxBorsa.Size = new System.Drawing.Size(100, 23);
            this.textBoxBorsa.TabIndex = 7;
            // 
            // buttonGoruntule
            // 
            this.buttonGoruntule.Location = new System.Drawing.Point(271, 272);
            this.buttonGoruntule.Name = "buttonGoruntule";
            this.buttonGoruntule.Size = new System.Drawing.Size(186, 51);
            this.buttonGoruntule.TabIndex = 8;
            this.buttonGoruntule.Text = "Goruntule";
            this.buttonGoruntule.UseVisualStyleBackColor = true;
            this.buttonGoruntule.Click += new System.EventHandler(this.buttonGoruntule_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 349);
            this.Controls.Add(this.buttonGoruntule);
            this.Controls.Add(this.textBoxBorsa);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.textBoxHisse);
            this.Controls.Add(this.labelbrs);
            this.Controls.Add(this.labelfy);
            this.Controls.Add(this.labelhs);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelbrs;
        private Label labelfy;
        private Label labelhs;
        private TextBox textBoxHisse;
        private TextBox textBoxFiyat;
        private TextBox textBoxBorsa;
        private Button buttonGoruntule;
    }
}