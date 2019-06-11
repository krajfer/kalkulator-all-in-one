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

        Double wynik = 0;
        String operacja = "";
        bool operacja_wykonana=false;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void pobieranieznakow(object sender, EventArgs e)   
        {
            if ((textBox1.Text == "0") || (operacja_wykonana)) //jesli przy pobieraniu znaku textBox1 == 0 
                textBox1.Clear();       //czysci textbox1 słuzyc ma to temu by na początku przy wpisywaniu liczby nie wyswietlało zera
            operacja_wykonana = false;
            Button z = (Button)sender;//pobieranie znaku z buttona
            aktualnie.Text += z.Text;
            if (z.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + z.Text;

            }
            else
                textBox1.Text = textBox1.Text + z.Text;//do textBox1 wpisywane bedą ciągiem liczby z wcisnietyh buttonow
        }


        private void dzialanie(object sender, EventArgs e)
        {
            Button z = (Button)sender; //pobieranie znaku z buttona
          
         
        
            if (wynik != 0)
            {
                bwynik.PerformClick();
                operacja = z.Text;
                aktualnie.Text = wynik + " " + operacja;
                operacja_wykonana = true;
                
            }
            else
            {

                operacja = z.Text;
                wynik = Double.Parse(textBox1.Text);
                aktualnie.Text = wynik + " " + operacja;
                operacja_wykonana = true;
            }
            
        }

        private void bwynik_Click(object sender, EventArgs e)
        {
            
            switch (operacja)
            {
                case "+":
                    textBox1.Text = (wynik + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (wynik - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (wynik * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (wynik / Double.Parse(textBox1.Text)).ToString();
                    break;                 
                case "^":
                    textBox1.Text = (Math.Pow(wynik, Double.Parse(textBox1.Text))).ToString();
                    break;
                default:
                    break;
            }
           
            operacja_wykonana = false;
            

        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }

        private void breset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            wynik = 0;
            aktualnie.Text = "";

        }

        private void bpierwiastek_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        }

        private void bpotega_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Pow(double.Parse(textBox1.Text),2)).ToString();
        }

        private void sin_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sin(double.Parse(textBox1.Text))).ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sin(double.Parse(textBox1.Text))).ToString();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Tan(double.Parse(textBox1.Text))).ToString();
        }

        private void potega3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Pow(double.Parse(textBox1.Text), 3)).ToString();
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void blog_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Log(double.Parse(textBox1.Text))).ToString();
        }
    }
}
