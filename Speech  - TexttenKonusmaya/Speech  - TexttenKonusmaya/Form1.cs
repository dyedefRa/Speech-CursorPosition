using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Eklenti

using SpeechLib;

namespace Speech____TexttenKonusmaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Konus_Click(object sender, EventArgs e)
        {
            SpVoice sp = new SpVoice();
            sp.Speak(txt_Girdi.Text);
        }
    }
}
