using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//=>
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace Speech___KonusmadanTexte
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices seceneklist;
        public Form1()
        {
            InitializeComponent();
            seceneklist = new Choices();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
            seceneklist.Add(new string[]
            {
                "Hello",
                "Okey",
                "Open Chrome",
                "What is the current time",
                "Thank You",
                "Close"
            });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = new System.Globalization.CultureInfo("en-US");
            Grammar gr = new Grammar(new GrammarBuilder(seceneklist));

            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sesi_Anladiginda;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error");
            }

        }

        private void sesi_Anladiginda(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text.ToString())
            {
                case "Hello":
                    ss.SpeakAsync("Hello Baki");
                    break;

                case "Okey":
                    ss.SpeakAsync("Okey Sur");
                    break;
                case "What is the current time":
                    ss.SpeakAsync("Current time is " + DateTime.Now.ToLongTimeString());
                    break;
                case "Open Chrome":
                    ss.SpeakAsync("i am going to open it");
                    Process.Start("chrome");
                    break;
                case "Thank you":
                    ss.SpeakAsync("Pleasure is mine Baki");
                    break;
                case "Close":
                    Application.Exit();
                    break;
                  
            }
            txt_Icerik.Text += e.Result.Text.ToString() + Environment.NewLine;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
        }
    }
}
