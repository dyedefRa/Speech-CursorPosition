using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//alltaki 3 taneyi ben ekledim
using System.Configuration;
using System.Threading;
using Microsoft.CognitiveServices.SpeechRecognition;


namespace SpeechBing
{
    public partial class Form1 : Form
    {
        AutoResetEvent _FinalResponceEvent;
        MicrophoneRecognitionClient mikrofonTanimaAlicisi;
        public Form1()
        {
            InitializeComponent();
            btn_Baslar.Text = "Kaydı başlat";
            _FinalResponceEvent = new AutoResetEvent(false);
            txt_Cikti.BackColor = Color.White;
            txt_Cikti.ForeColor = Color.Black;

        }

        private void SesiYaziyaDonustur()
        {
            var sesTanimaModu = SpeechRecognitionMode.ShortPhrase;
            string dil = "en-US";
            string scriptionKEY = ConfigurationManager.AppSettings["MicrosoftSpeechApiKey"].ToString();
            mikrofonTanimaAlicisi = SpeechRecognitionServiceFactory.CreateMicrophoneClient(sesTanimaModu, dil, scriptionKEY);
            mikrofonTanimaAlicisi.OnPartialResponseReceived += OnPartialResponseReceived_HANDLER;
            mikrofonTanimaAlicisi.StartMicAndRecognition();

        }

        private void OnPartialResponseReceived_HANDLER(object sender, PartialSpeechResponseEventArgs e)
        {
            string result = e.PartialResult;
            txt_Cikti.BeginInvoke((Action)(() =>
           {
               txt_Cikti.Text = (result);
               txt_Cikti.Text += "\n";
           }
            ));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Baslar_Click(object sender, EventArgs e)
        {
            this.Text = "Dinleniyor..";
            this.Enabled = false;
            txt_Cikti.BackColor = Color.Green;
      
            txt_Cikti.ForeColor = Color.White;
            SesiYaziyaDonustur();

        }

        private void btn_Bitir_Click(object sender, EventArgs e)
        {
            txt_Cikti.BeginInvoke((Action)(() =>
            {
                _FinalResponceEvent.Set();
                mikrofonTanimaAlicisi.EndMicAndRecognition();
                mikrofonTanimaAlicisi.Dispose();
                mikrofonTanimaAlicisi = null;
                btn_Baslar.Text = "Kayda Başla";
                btn_Baslar.Enabled = true;
                txt_Cikti.BackColor = Color.White;
                txt_Cikti.ForeColor = Color.Black;
            }
           ));
        }
    }
}
