namespace FormDers3
{
    partial class ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.buttonDur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 146);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(432, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonBasla
            // 
            this.buttonBasla.Location = new System.Drawing.Point(35, 52);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(195, 23);
            this.buttonBasla.TabIndex = 1;
            this.buttonBasla.Text = "Başla";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // buttonDur
            // 
            this.buttonDur.Location = new System.Drawing.Point(272, 52);
            this.buttonDur.Name = "buttonDur";
            this.buttonDur.Size = new System.Drawing.Size(195, 23);
            this.buttonDur.TabIndex = 1;
            this.buttonDur.Text = "Dur";
            this.buttonDur.UseVisualStyleBackColor = true;
            this.buttonDur.Click += new System.EventHandler(this.buttonDur_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(559, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDur);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressBar";
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private Button buttonBasla;
        private Button buttonDur;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}