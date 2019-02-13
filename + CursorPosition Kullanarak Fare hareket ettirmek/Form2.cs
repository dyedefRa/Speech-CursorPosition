using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int w = Convert.ToInt32(textBox3.Text);
            int h = Convert.ToInt32(textBox4.Text);

            Point xy = new Point(x, y);
            Size wh = new Size(w, h);

            Button b1 = new Button();
            b1.Width = w;
            b1.Height = h;
            this.Controls.Add(b1);
            b1.Click += B1_Click;
            
            

        }

        private void B1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
