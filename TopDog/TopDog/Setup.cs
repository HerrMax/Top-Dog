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
    public partial class Setup : Form
    {
        public SpeechSynthesizer kyle;
        public Setup()
        {
            InitializeComponent();
            kyle = new SpeechSynthesizer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userName.Text == "")
            {
                MessageBox.Show("You must have a name.");
                return;
            }
            if(cardAmount.Value < 4 || cardAmount.Value > 30 || cardAmount.Value % 2 != 0) {
                MessageBox.Show("You must enter an even number between 4 and 30.");
                return;
            }

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            kyle.Speak(userName.Text);
        }

        private void cardAmount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
