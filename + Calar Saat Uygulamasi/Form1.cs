using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat, dakika, saniye;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i.ToString("D2"));
            }
            for (int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i.ToString("D2"));
            }
            for (int i = 0; i < 1000; i++)
            {
                comboBox3.Items.Add(i.ToString("D3"));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Text = button1.Text;
        }

        private void btnAyarla_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;


            try
            {

                saat = Convert.ToInt32(comboBox1.Text);
                dakika = Convert.ToInt32(comboBox2.Text);
                saniye = Convert.ToInt32(comboBox3.Text);

                if (groupBox1.Text == button1.Text)
                {



                }
                else if (groupBox1.Text == button2.Text)
                {
                    TimeSpan sa = new TimeSpan(saat, dakika, saniye);
                   DateTime k =  DateTime.Now.Add(sa);
                   if (label2.Text == k.ToLongTimeString())
                    { MessageBox.Show("HEADSHOT"); }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!.Alanlar boş yada sayı girilmemiş..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Text = button2.Text;

        }
    }
}
