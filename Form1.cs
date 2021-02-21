using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMyNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numberOutput.Text = "";
        }
        int number = 0;
        int attempt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            number = rand.Next(0, 100);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            number = rand.Next(0, 1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            number = rand.Next(0, 10000);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text == number.ToString())
                {
                    numberOutput.ForeColor = Color.Green;
                    numberOutput.Text = "Yes";
                    ruler.Text = "";
                }
                if (textBox1.Text != number.ToString())
                {
                    if (int.Parse(textBox1.Text) > number)
                    {
                        ruler.Text = "Мое число меньше";
                        
                    }
                    else
                    {
                        ruler.Text = "Мое число больше";
                        
                    }
                    numberOutput.ForeColor = Color.Red;
                    numberOutput.Text = "No";
                    textBox1.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruler.Text = "";
            numberOutput.Text = "";
            textBox1.Text = "";
        }
    }
}
