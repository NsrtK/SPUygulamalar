namespace FormDers4
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonbaslat = new System.Windows.Forms.Button();
            this.buttondurdur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(99, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(670, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 8);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // buttonbaslat
            // 
            this.buttonbaslat.Location = new System.Drawing.Point(104, 224);
            this.buttonbaslat.Name = "buttonbaslat";
            this.buttonbaslat.Size = new System.Drawing.Size(75, 23);
            this.buttonbaslat.TabIndex = 2;
            this.buttonbaslat.Text = "Başlat";
            this.buttonbaslat.UseVisualStyleBackColor = true;
            this.buttonbaslat.Click += new System.EventHandler(this.buttonbaslat_Click);
            // 
            // buttondurdur
            // 
            this.buttondurdur.Location = new System.Drawing.Point(335, 224);
            this.buttondurdur.Name = "buttondurdur";
            this.buttondurdur.Size = new System.Drawing.Size(75, 23);
            this.buttondurdur.TabIndex = 2;
            this.buttondurdur.Text = "Durdur";
            this.buttondurdur.UseVisualStyleBackColor = true;
            this.buttondurdur.Click += new System.EventHandler(this.buttondurdur_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 281);
            this.Controls.Add(this.buttondurdur);
            this.Controls.Add(this.buttonbaslat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonbaslat;
        private Button buttondurdur;
        private System.Windows.Forms.Timer timer1;
    }
}