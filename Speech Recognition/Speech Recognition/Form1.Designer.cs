namespace Speech_Recognition
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture_Pasif = new System.Windows.Forms.PictureBox();
            this.picture_Aktif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Pasif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Aktif)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Pasif
            // 
            this.picture_Pasif.Image = ((System.Drawing.Image)(resources.GetObject("picture_Pasif.Image")));
            this.picture_Pasif.Location = new System.Drawing.Point(29, 42);
            this.picture_Pasif.Name = "picture_Pasif";
            this.picture_Pasif.Size = new System.Drawing.Size(160, 160);
            this.picture_Pasif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Pasif.TabIndex = 0;
            this.picture_Pasif.TabStop = false;
            this.picture_Pasif.Click += new System.EventHandler(this.picture_Pasif_Click);
            // 
            // picture_Aktif
            // 
            this.picture_Aktif.Image = ((System.Drawing.Image)(resources.GetObject("picture_Aktif.Image")));
            this.picture_Aktif.Location = new System.Drawing.Point(29, 42);
            this.picture_Aktif.Name = "picture_Aktif";
            this.picture_Aktif.Size = new System.Drawing.Size(160, 160);
            this.picture_Aktif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Aktif.TabIndex = 1;
            this.picture_Aktif.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(229, 240);
            this.Controls.Add(this.picture_Pasif);
            this.Controls.Add(this.picture_Aktif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Ceyda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Pasif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Aktif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_Pasif;
        private System.Windows.Forms.PictureBox picture_Aktif;
    }
}

