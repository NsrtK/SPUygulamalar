namespace FormDers7_Encapsulation
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
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxDers = new System.Windows.Forms.TextBox();
            this.textBoxNot1 = new System.Windows.Forms.TextBox();
            this.textBoxNot2 = new System.Windows.Forms.TextBox();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.listViewTablo = new System.Windows.Forms.ListView();
            this.ChAdSoyad = new System.Windows.Forms.ColumnHeader();
            this.CHDers = new System.Windows.Forms.ColumnHeader();
            this.CHOrt = new System.Windows.Forms.ColumnHeader();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(40, 21);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(57, 15);
            this.labelAdSoyad.TabIndex = 0;
            this.labelAdSoyad.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Not 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Not 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ortalama";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(101, 18);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(168, 23);
            this.textBoxAdSoyad.TabIndex = 1;
            // 
            // textBoxDers
            // 
            this.textBoxDers.Location = new System.Drawing.Point(101, 48);
            this.textBoxDers.Name = "textBoxDers";
            this.textBoxDers.Size = new System.Drawing.Size(168, 23);
            this.textBoxDers.TabIndex = 1;
            // 
            // textBoxNot1
            // 
            this.textBoxNot1.Location = new System.Drawing.Point(101, 75);
            this.textBoxNot1.Name = "textBoxNot1";
            this.textBoxNot1.Size = new System.Drawing.Size(100, 23);
            this.textBoxNot1.TabIndex = 1;
            // 
            // textBoxNot2
            // 
            this.textBoxNot2.Location = new System.Drawing.Point(101, 104);
            this.textBoxNot2.Name = "textBoxNot2";
            this.textBoxNot2.Size = new System.Drawing.Size(100, 23);
            this.textBoxNot2.TabIndex = 1;
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Location = new System.Drawing.Point(101, 133);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(100, 23);
            this.textBoxOrt.TabIndex = 1;
            // 
            // listViewTablo
            // 
            this.listViewTablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChAdSoyad,
            this.CHDers,
            this.CHOrt});
            this.listViewTablo.Location = new System.Drawing.Point(40, 188);
            this.listViewTablo.Name = "listViewTablo";
            this.listViewTablo.Size = new System.Drawing.Size(644, 97);
            this.listViewTablo.TabIndex = 2;
            this.listViewTablo.UseCompatibleStateImageBehavior = false;
            this.listViewTablo.View = System.Windows.Forms.View.Details;
            // 
            // ChAdSoyad
            // 
            this.ChAdSoyad.Text = "Ad Soyad";
            this.ChAdSoyad.Width = 200;
            // 
            // CHDers
            // 
            this.CHDers.Text = "Ders";
            this.CHDers.Width = 150;
            // 
            // CHOrt
            // 
            this.CHOrt.Text = "Ortalama";
            this.CHOrt.Width = 100;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(318, 23);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(212, 133);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(560, 23);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(75, 133);
            this.buttonTemizle.TabIndex = 4;
            this.buttonTemizle.Text = "Giriş Alanını Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.listViewTablo);
            this.Controls.Add(this.textBoxOrt);
            this.Controls.Add(this.textBoxNot2);
            this.Controls.Add(this.textBoxNot1);
            this.Controls.Add(this.textBoxDers);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAdSoyad);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAdSoyad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxAdSoyad;
        private TextBox textBoxDers;
        private TextBox textBoxNot1;
        private TextBox textBoxNot2;
        private TextBox textBoxOrt;
        private ListView listViewTablo;
        private ColumnHeader ChAdSoyad;
        private ColumnHeader CHDers;
        private ColumnHeader CHOrt;
        private Button buttonKaydet;
        private Button buttonTemizle;
    }
}