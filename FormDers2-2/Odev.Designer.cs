namespace FormDers2_2
{
    partial class Odev
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxOgretmen = new System.Windows.Forms.ListBox();
            this.listBoxOgrenci = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonOgretmen = new System.Windows.Forms.RadioButton();
            this.radioButtonOgrenci = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 25);
            this.textBox1.TabIndex = 1;
            // 
            // listBoxOgretmen
            // 
            this.listBoxOgretmen.FormattingEnabled = true;
            this.listBoxOgretmen.ItemHeight = 17;
            this.listBoxOgretmen.Location = new System.Drawing.Point(73, 169);
            this.listBoxOgretmen.Name = "listBoxOgretmen";
            this.listBoxOgretmen.Size = new System.Drawing.Size(196, 106);
            this.listBoxOgretmen.TabIndex = 2;
            // 
            // listBoxOgrenci
            // 
            this.listBoxOgrenci.FormattingEnabled = true;
            this.listBoxOgrenci.ItemHeight = 17;
            this.listBoxOgrenci.Location = new System.Drawing.Point(413, 169);
            this.listBoxOgrenci.Name = "listBoxOgrenci";
            this.listBoxOgrenci.Size = new System.Drawing.Size(194, 106);
            this.listBoxOgrenci.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğretmenler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğrenciler";
            // 
            // radioButtonOgretmen
            // 
            this.radioButtonOgretmen.AutoSize = true;
            this.radioButtonOgretmen.Location = new System.Drawing.Point(181, 87);
            this.radioButtonOgretmen.Name = "radioButtonOgretmen";
            this.radioButtonOgretmen.Size = new System.Drawing.Size(88, 21);
            this.radioButtonOgretmen.TabIndex = 3;
            this.radioButtonOgretmen.Text = "Öğretmen";
            this.radioButtonOgretmen.UseVisualStyleBackColor = true;
            this.radioButtonOgretmen.CheckedChanged += new System.EventHandler(this.radioButtonOgretmen_CheckedChanged);
            // 
            // radioButtonOgrenci
            // 
            this.radioButtonOgrenci.AutoSize = true;
            this.radioButtonOgrenci.Location = new System.Drawing.Point(337, 87);
            this.radioButtonOgrenci.Name = "radioButtonOgrenci";
            this.radioButtonOgrenci.Size = new System.Drawing.Size(73, 21);
            this.radioButtonOgrenci.TabIndex = 4;
            this.radioButtonOgrenci.Text = "Öğrenci";
            this.radioButtonOgrenci.UseVisualStyleBackColor = true;
            this.radioButtonOgrenci.CheckedChanged += new System.EventHandler(this.radioButtonOgrenci_CheckedChanged_1);
            // 
            // Odev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 510);
            this.Controls.Add(this.radioButtonOgrenci);
            this.Controls.Add(this.radioButtonOgretmen);
            this.Controls.Add(this.listBoxOgrenci);
            this.Controls.Add(this.listBoxOgretmen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Odev";
            this.Text = "Odev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox listBoxOgretmen;
        private ListBox listBoxOgrenci;
        private Label label2;
        private Label label3;
        private RadioButton radioButtonOgretmen;
        private RadioButton radioButtonOgrenci;
    }
}