namespace FormDers2
{
    partial class Form2
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
            this.checkBoxYazilim = new System.Windows.Forms.CheckBox();
            this.checkBoxOffice = new System.Windows.Forms.CheckBox();
            this.checkBoxDil = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbkisiler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxYazilim
            // 
            this.checkBoxYazilim.AutoSize = true;
            this.checkBoxYazilim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBoxYazilim.Location = new System.Drawing.Point(66, 99);
            this.checkBoxYazilim.Name = "checkBoxYazilim";
            this.checkBoxYazilim.Size = new System.Drawing.Size(202, 25);
            this.checkBoxYazilim.TabIndex = 0;
            this.checkBoxYazilim.Text = "Yazılım biliyor musunuz?";
            this.checkBoxYazilim.UseVisualStyleBackColor = true;
            // 
            // checkBoxOffice
            // 
            this.checkBoxOffice.AutoSize = true;
            this.checkBoxOffice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBoxOffice.Location = new System.Drawing.Point(66, 140);
            this.checkBoxOffice.Name = "checkBoxOffice";
            this.checkBoxOffice.Size = new System.Drawing.Size(217, 25);
            this.checkBoxOffice.TabIndex = 0;
            this.checkBoxOffice.Text = "MS Office biliyor musunuz?";
            this.checkBoxOffice.UseVisualStyleBackColor = true;
            // 
            // checkBoxDil
            // 
            this.checkBoxDil.AutoSize = true;
            this.checkBoxDil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDil.Location = new System.Drawing.Point(66, 180);
            this.checkBoxDil.Name = "checkBoxDil";
            this.checkBoxDil.Size = new System.Drawing.Size(230, 25);
            this.checkBoxDil.TabIndex = 0;
            this.checkBoxDil.Text = "Yabancı Dil biliyor musunuz?";
            this.checkBoxDil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınız Soyadınız";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 23);
            this.textBox1.TabIndex = 2;
            // 
            // lbkisiler
            // 
            this.lbkisiler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbkisiler.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbkisiler.FormattingEnabled = true;
            this.lbkisiler.ItemHeight = 17;
            this.lbkisiler.Location = new System.Drawing.Point(353, 17);
            this.lbkisiler.Name = "lbkisiler";
            this.lbkisiler.Size = new System.Drawing.Size(314, 208);
            this.lbkisiler.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(679, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbkisiler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDil);
            this.Controls.Add(this.checkBoxOffice);
            this.Controls.Add(this.checkBoxYazilim);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBoxYazilim;
        private CheckBox checkBoxOffice;
        private CheckBox checkBoxDil;
        private Label label1;
        private TextBox textBox1;
        private ListBox lbkisiler;
        private Button button1;
    }
}