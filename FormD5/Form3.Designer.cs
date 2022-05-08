namespace FormD5
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHisse = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelBorsa = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hisse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Borsa";
            // 
            // labelHisse
            // 
            this.labelHisse.AutoSize = true;
            this.labelHisse.Location = new System.Drawing.Point(299, 70);
            this.labelHisse.Name = "labelHisse";
            this.labelHisse.Size = new System.Drawing.Size(17, 15);
            this.labelHisse.TabIndex = 0;
            this.labelHisse.Text = "--";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(299, 122);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(17, 15);
            this.labelFiyat.TabIndex = 0;
            this.labelFiyat.Text = "--";
            // 
            // labelBorsa
            // 
            this.labelBorsa.AutoSize = true;
            this.labelBorsa.Location = new System.Drawing.Point(299, 176);
            this.labelBorsa.Name = "labelBorsa";
            this.labelBorsa.Size = new System.Drawing.Size(17, 15);
            this.labelBorsa.TabIndex = 0;
            this.labelBorsa.Text = "--";
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(449, 63);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 141);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Hisse Bilgi Al";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 134);
            this.button1.TabIndex = 2;
            this.button1.Text = "2. Hisse Bilgi Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.labelBorsa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHisse);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelHisse;
        private Label labelFiyat;
        private Label labelBorsa;
        private Button buttonUp;
        private Button button1;
    }
}