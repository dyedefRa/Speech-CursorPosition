namespace Speech____TexttenKonusmaya
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
            this.btn_Konus = new System.Windows.Forms.Button();
            this.txt_Girdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Konus
            // 
            this.btn_Konus.Location = new System.Drawing.Point(71, 139);
            this.btn_Konus.Name = "btn_Konus";
            this.btn_Konus.Size = new System.Drawing.Size(142, 84);
            this.btn_Konus.TabIndex = 0;
            this.btn_Konus.Text = "KONUŞ";
            this.btn_Konus.UseVisualStyleBackColor = true;
            this.btn_Konus.Click += new System.EventHandler(this.btn_Konus_Click);
            // 
            // txt_Girdi
            // 
            this.txt_Girdi.Location = new System.Drawing.Point(12, 33);
            this.txt_Girdi.Multiline = true;
            this.txt_Girdi.Name = "txt_Girdi";
            this.txt_Girdi.Size = new System.Drawing.Size(258, 88);
            this.txt_Girdi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txt_Girdi);
            this.Controls.Add(this.btn_Konus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Konus;
        private System.Windows.Forms.TextBox txt_Girdi;
    }
}

