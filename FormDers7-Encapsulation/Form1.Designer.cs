namespace FormDers7_Encapsulation
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
            this.textBoxSemt = new System.Windows.Forms.TextBox();
            this.textBoxOdaSayisi = new System.Windows.Forms.TextBox();
            this.textBoxKatNo = new System.Windows.Forms.TextBox();
            this.textBoxAlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.listViewEmlak = new System.Windows.Forms.ListView();
            this.LWSemt = new System.Windows.Forms.ColumnHeader();
            this.LWOda_Sayısı = new System.Windows.Forms.ColumnHeader();
            this.LWKat_No = new System.Windows.Forms.ColumnHeader();
            this.LWAlan = new System.Windows.Forms.ColumnHeader();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSemt
            // 
            this.textBoxSemt.Location = new System.Drawing.Point(149, 34);
            this.textBoxSemt.Name = "textBoxSemt";
            this.textBoxSemt.Size = new System.Drawing.Size(100, 23);
            this.textBoxSemt.TabIndex = 0;
            // 
            // textBoxOdaSayisi
            // 
            this.textBoxOdaSayisi.Location = new System.Drawing.Point(149, 103);
            this.textBoxOdaSayisi.Name = "textBoxOdaSayisi";
            this.textBoxOdaSayisi.Size = new System.Drawing.Size(100, 23);
            this.textBoxOdaSayisi.TabIndex = 0;
            // 
            // textBoxKatNo
            // 
            this.textBoxKatNo.Location = new System.Drawing.Point(149, 178);
            this.textBoxKatNo.Name = "textBoxKatNo";
            this.textBoxKatNo.Size = new System.Drawing.Size(100, 23);
            this.textBoxKatNo.TabIndex = 0;
            // 
            // textBoxAlan
            // 
            this.textBoxAlan.Location = new System.Drawing.Point(149, 253);
            this.textBoxAlan.Name = "textBoxAlan";
            this.textBoxAlan.Size = new System.Drawing.Size(100, 23);
            this.textBoxAlan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kat No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alan";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(340, 78);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(176, 134);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // listViewEmlak
            // 
            this.listViewEmlak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LWSemt,
            this.LWOda_Sayısı,
            this.LWKat_No,
            this.LWAlan});
            this.listViewEmlak.Location = new System.Drawing.Point(51, 303);
            this.listViewEmlak.Name = "listViewEmlak";
            this.listViewEmlak.Size = new System.Drawing.Size(535, 113);
            this.listViewEmlak.TabIndex = 3;
            this.listViewEmlak.UseCompatibleStateImageBehavior = false;
            this.listViewEmlak.View = System.Windows.Forms.View.Details;
            // 
            // LWSemt
            // 
            this.LWSemt.Text = "Semt";
            this.LWSemt.Width = 100;
            // 
            // LWOda_Sayısı
            // 
            this.LWOda_Sayısı.Text = "Oda_Sayısı";
            this.LWOda_Sayısı.Width = 100;
            // 
            // LWKat_No
            // 
            this.LWKat_No.Text = "Kat_No";
            this.LWKat_No.Width = 100;
            // 
            // LWAlan
            // 
            this.LWAlan.Text = "Alan";
            this.LWAlan.Width = 100;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(347, 231);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(169, 40);
            this.buttonTemizle.TabIndex = 4;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.listViewEmlak);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAlan);
            this.Controls.Add(this.textBoxKatNo);
            this.Controls.Add(this.textBoxOdaSayisi);
            this.Controls.Add(this.textBoxSemt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSemt;
        private TextBox textBoxOdaSayisi;
        private TextBox textBoxKatNo;
        private TextBox textBoxAlan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnKaydet;
        private ListView listViewEmlak;
        private ColumnHeader LWSemt;
        private ColumnHeader LWOda_Sayısı;
        private ColumnHeader LWKat_No;
        private ColumnHeader LWAlan;
        private Button buttonTemizle;
    }
}