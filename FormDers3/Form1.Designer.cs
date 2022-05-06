namespace FormDers3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSn = new System.Windows.Forms.Label();
            this.labelDkk = new System.Windows.Forms.Label();
            this.textBoxDkk = new System.Windows.Forms.TextBox();
            this.buttonSayac = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(171, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dakika";
            // 
            // labelSn
            // 
            this.labelSn.AutoSize = true;
            this.labelSn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSn.Location = new System.Drawing.Point(256, 170);
            this.labelSn.Name = "labelSn";
            this.labelSn.Size = new System.Drawing.Size(22, 21);
            this.labelSn.TabIndex = 0;
            this.labelSn.Text = "--";
            // 
            // labelDkk
            // 
            this.labelDkk.AutoSize = true;
            this.labelDkk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDkk.Location = new System.Drawing.Point(171, 170);
            this.labelDkk.Name = "labelDkk";
            this.labelDkk.Size = new System.Drawing.Size(22, 21);
            this.labelDkk.TabIndex = 0;
            this.labelDkk.Text = "--";
            // 
            // textBoxDkk
            // 
            this.textBoxDkk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDkk.Location = new System.Drawing.Point(256, 81);
            this.textBoxDkk.Name = "textBoxDkk";
            this.textBoxDkk.Size = new System.Drawing.Size(169, 29);
            this.textBoxDkk.TabIndex = 1;
            // 
            // buttonSayac
            // 
            this.buttonSayac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSayac.Location = new System.Drawing.Point(451, 81);
            this.buttonSayac.Name = "buttonSayac";
            this.buttonSayac.Size = new System.Drawing.Size(196, 29);
            this.buttonSayac.TabIndex = 2;
            this.buttonSayac.Text = "Sayacı Başlat";
            this.buttonSayac.UseVisualStyleBackColor = true;
            this.buttonSayac.Click += new System.EventHandler(this.buttonSayac_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 352);
            this.Controls.Add(this.buttonSayac);
            this.Controls.Add(this.textBoxDkk);
            this.Controls.Add(this.labelDkk);
            this.Controls.Add(this.labelSn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelSn;
        private Label labelDkk;
        private TextBox textBoxDkk;
        private Button buttonSayac;
        private System.Windows.Forms.Timer timer1;
    }
}