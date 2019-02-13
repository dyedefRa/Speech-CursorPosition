namespace WindowsFormsApp11
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
            this.components = new System.ComponentModel.Container();
            this.btnAyarla = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnH = new System.Windows.Forms.Button();
            this.btnDK = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAyarla
            // 
            this.btnAyarla.Location = new System.Drawing.Point(182, 62);
            this.btnAyarla.Name = "btnAyarla";
            this.btnAyarla.Size = new System.Drawing.Size(89, 55);
            this.btnAyarla.TabIndex = 0;
            this.btnAyarla.Text = "Ayarla";
            this.btnAyarla.UseVisualStyleBackColor = true;
            this.btnAyarla.Click += new System.EventHandler(this.btnAyarla_Click);
            // 
            // btnCik
            // 
            this.btnCik.Location = new System.Drawing.Point(563, 423);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(89, 55);
            this.btnCik.TabIndex = 1;
            this.btnCik.Text = "ÇIK";
            this.btnCik.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(78, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(68, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(78, 132);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(68, 24);
            this.comboBox3.TabIndex = 4;
            // 
            // btnH
            // 
            this.btnH.Enabled = false;
            this.btnH.Location = new System.Drawing.Point(14, 28);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(58, 24);
            this.btnH.TabIndex = 5;
            this.btnH.Text = "SAAT";
            this.btnH.UseVisualStyleBackColor = true;
            // 
            // btnDK
            // 
            this.btnDK.Enabled = false;
            this.btnDK.Location = new System.Drawing.Point(14, 78);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(58, 24);
            this.btnDK.TabIndex = 6;
            this.btnDK.Text = "DK";
            this.btnDK.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.Enabled = false;
            this.btnS.Location = new System.Drawing.Point(14, 132);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(58, 24);
            this.btnS.TabIndex = 7;
            this.btnS.Text = "SN";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Güncel Saat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Geri Sayım";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAyarla);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.btnS);
            this.groupBox1.Controls.Add(this.btnH);
            this.groupBox1.Controls.Add(this.btnDK);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(33, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 182);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "--";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Belirlenen Saat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 514);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyarla;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}

