using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Speech_Recognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SesTanimaAyarlari();
        }

        SpeechRecognitionEngine sesTanimaEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSyn = new SpeechSynthesizer();
        bool izin;
        private void picture_Pasif_Click(object sender, EventArgs e)
        {
            picture_Pasif.Visible = false;
             izin = true;
            //Burada çalıştırıyor=>
            sesTanimaEngine.RecognizeAsync();
           


        }

      
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      private  void SesTanimaAyarlari()
        {
          
            string[] ihtimaller = { "Hello", "Okey", "Sure" };
            Choices secenekler = new Choices(ihtimaller);
            GrammarBuilder gramerBuilder = new GrammarBuilder(secenekler);
            gramerBuilder.Culture = new System.Globalization.CultureInfo("en-UK");
            Grammar gramer = new Grammar(gramerBuilder);
            //grameri yukleyelim
            sesTanimaEngine.LoadGrammar(gramer);
            //recognition mikrofonunu default olarak ayalayalım
            sesTanimaEngine.SetInputToDefaultAudioDevice();
            //ses tanıdığında alttaki evente gitsin
            sesTanimaEngine.SpeechRecognized += ses_Tanidiginda;
        }

      

        //SES ALGILADIGINDA BU EVENTE GIRSIN
        void ses_Tanidiginda(object sender, SpeechRecognizedEventArgs e)
        {
            speechSyn.SelectVoiceByHints(VoiceGender.Female);

            if (izin==true)
            {
                picture_Pasif.Visible = true;
                izin = false;
                if (e.Result.Text == "Hello")
                {
                    MessageBox.Show("Hello");
                }
                else if (e.Result.Text == "Okey")
                {
                    MessageBox.Show("OKEY");
                }
                else if (e.Result.Text == "Sure")
                {
                    MessageBox.Show("Sure");
                }

            }

        }

    }
}
