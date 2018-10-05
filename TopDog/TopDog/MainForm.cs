using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TopDog
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Juicy boy kyle ;)
        /// </summary>
        public SpeechSynthesizer kyle;

        public MainForm()
        {
            kyle = new SpeechSynthesizer();
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void friendlinessButton_Click(object sender, EventArgs e)
        {
            
            Speak("Friendliness");
        }

        private void droolButton_Click(object sender, EventArgs e)
        {
            Speak("Drool");
        }
        private void exerciseButton_Click(object sender, EventArgs e)
        {
            Speak("Exercise");
        }

        private void intelligenceButton_Click(object sender, EventArgs e)
        {
            Speak("Intelligence");
        }

        private void Speak(string words)
        {
            kyle.SpeakAsync(words);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
