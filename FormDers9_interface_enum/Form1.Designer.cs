namespace FormDers9_interface_enum
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmusterAD = new System.Windows.Forms.TextBox();
            this.tbmusterSoyAD = new System.Windows.Forms.TextBox();
            this.tbAdet = new System.Windows.Forms.TextBox();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.btnHsGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat";
            // 
            // tbmusterAD
            // 
            this.tbmusterAD.Location = new System.Drawing.Point(180, 35);
            this.tbmusterAD.Name = "tbmusterAD";
            this.tbmusterAD.Size = new System.Drawing.Size(100, 23);
            this.tbmusterAD.TabIndex = 1;
            // 
            // tbmusterSoyAD
            // 
            this.tbmusterSoyAD.Location = new System.Drawing.Point(180, 80);
            this.tbmusterSoyAD.Name = "tbmusterSoyAD";
            this.tbmusterSoyAD.Size = new System.Drawing.Size(100, 23);
            this.tbmusterSoyAD.TabIndex = 1;
            // 
            // tbAdet
            // 
            this.tbAdet.Location = new System.Drawing.Point(180, 122);
            this.tbAdet.Name = "tbAdet";
            this.tbAdet.Size = new System.Drawing.Size(100, 23);
            this.tbAdet.TabIndex = 1;
            // 
            // tbFiyat
            // 
            this.tbFiyat.Location = new System.Drawing.Point(180, 164);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(100, 23);
            this.tbFiyat.TabIndex = 1;
            // 
            // btnHsGoster
            // 
            this.btnHsGoster.Location = new System.Drawing.Point(332, 35);
            this.btnHsGoster.Name = "btnHsGoster";
            this.btnHsGoster.Size = new System.Drawing.Size(197, 152);
            this.btnHsGoster.TabIndex = 2;
            this.btnHsGoster.Text = "Hesapla ve Göster";
            this.btnHsGoster.UseVisualStyleBackColor = true;
            this.btnHsGoster.Click += new System.EventHandler(this.btnHsGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 272);
            this.Controls.Add(this.btnHsGoster);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.tbAdet);
            this.Controls.Add(this.tbmusterSoyAD);
            this.Controls.Add(this.tbmusterAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbmusterAD;
        private TextBox tbmusterSoyAD;
        private TextBox tbAdet;
        private TextBox tbFiyat;
        private Button btnHsGoster;
    }
}