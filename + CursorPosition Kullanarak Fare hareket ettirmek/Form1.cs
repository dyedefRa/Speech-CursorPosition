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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(15, 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point sa = Cursor.Position;
            sa.X +=5;
            sa.Y +=5;
            Cursor.Position = sa;
        }
        int screenX;
        int screenY;
        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            screenX= Screen.PrimaryScreen.Bounds.Width;
            screenY = Screen.PrimaryScreen.Bounds.Height;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Point m = Cursor.Position;
            m.X += 20;
            m.Y += 2;
            if (m.Y > screenY)
                m.Y = 0;
            if (m.X > screenX)
                m.X = 0;
            Cursor.Position = m;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}
