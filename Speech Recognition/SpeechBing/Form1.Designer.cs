namespace SpeechBing
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
            this.btn_Baslar = new System.Windows.Forms.Button();
            this.txt_Cikti = new System.Windows.Forms.TextBox();
            this.btn_Bitir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Baslar
            // 
            this.btn_Baslar.Location = new System.Drawing.Point(52, 356);
            this.btn_Baslar.Name = "btn_Baslar";
            this.btn_Baslar.Size = new System.Drawing.Size(171, 66);
            this.btn_Baslar.TabIndex = 0;
            this.btn_Baslar.Text = "BAŞLAT";
            this.btn_Baslar.UseVisualStyleBackColor = true;
            this.btn_Baslar.Click += new System.EventHandler(this.btn_Baslar_Click);
            // 
            // txt_Cikti
            // 
            this.txt_Cikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Cikti.Location = new System.Drawing.Point(12, 12);
            this.txt_Cikti.Multiline = true;
            this.txt_Cikti.Name = "txt_Cikti";
            this.txt_Cikti.Size = new System.Drawing.Size(676, 303);
            this.txt_Cikti.TabIndex = 1;
            // 
            // btn_Bitir
            // 
            this.btn_Bitir.Location = new System.Drawing.Point(288, 356);
            this.btn_Bitir.Name = "btn_Bitir";
            this.btn_Bitir.Size = new System.Drawing.Size(171, 66);
            this.btn_Bitir.TabIndex = 2;
            this.btn_Bitir.Text = "BITIR";
            this.btn_Bitir.UseVisualStyleBackColor = true;
            this.btn_Bitir.Click += new System.EventHandler(this.btn_Bitir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 434);
            this.Controls.Add(this.btn_Bitir);
            this.Controls.Add(this.txt_Cikti);
            this.Controls.Add(this.btn_Baslar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Baslar;
        private System.Windows.Forms.TextBox txt_Cikti;
        private System.Windows.Forms.Button btn_Bitir;
    }
}

