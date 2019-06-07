using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalku_all_in_one
{
    public partial class Kalkulator : UserControl
    {
        double liczba1;
        string operacja;
        bool operacjazrobiona=false;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bpiec_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }

        }

        private void bdodawanie_Click(object sender, EventArgs e)
        {
           
            operacja = "+";
            textBox1.Text = textBox1.Text + "+";
            operacjazrobiona = true;
        }

        private void bodejmowanie_Click(object sender, EventArgs e)
        {
           
            operacja = "-";
            textBox1.Text = textBox1.Text + "-";
            operacjazrobiona = true;
        }

        private void bmnozenie_Click(object sender, EventArgs e)
        {
            
            operacja = "*";
            textBox1.Text = textBox1.Text + "*";
            operacjazrobiona = true;
        }

        private void bdzielenie_Click(object sender, EventArgs e)
        {
            
            operacja = "/";
            textBox1.Text = textBox1.Text + "/";
            operacjazrobiona = true;
        }

        private void bpierwiastek_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        }

        private void bpotega_Click(object sender, EventArgs e)
        {
            textBox1.Text = (liczba1 * liczba1).ToString();
        }

        private void breset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            liczba1 = 0;
           
            operacja = null;
        }

        private void bprzecinek_Click(object sender, EventArgs e)
        {

            {
                textBox1.Text = textBox1.Text + ",";
            }
            operacjazrobiona = true;
        }

        private void bzero_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" )
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void btrzy_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void bdwa_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" )
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void bjeden_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void bszesc_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }



        private void bcztery_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void bdziewiec_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void bosiem_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void bsiedem_Click(object sender, EventArgs e)
        {
            operacjazrobiona = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }
        private void bwynik_Click(object sender, EventArgs e)
        {
            double liczba2=0;
            double wynik;

           // liczba2 = decimal.Parse(textBox1.Text);
            switch (operacja)
            {
  
                case "+":
                    textBox1.Text=(wynik = (liczba1 - liczba2)).ToString(); 
                    break;
                case "-":
                    textBox1.Text = (wynik= (liczba1 - liczba2)).ToString();
                    break;
                case "*":
                    textBox1.Text = (wynik = (liczba1 * liczba2)).ToString();
                    break;
                case "/":
                    textBox1.Text = (wynik = (liczba1 / liczba2)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
