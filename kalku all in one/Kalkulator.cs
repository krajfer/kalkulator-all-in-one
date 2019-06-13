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

        public void pobieranieznakow(object sender, EventArgs e)   
        {
            if ((textBox1.Text == "0") || (operacja_wykonana)) //jesli przy pobieraniu znaku textBox1 == 0 
                textBox1.Clear();       //czysci textbox1 słuzyc ma to temu by na początku przy wpisywaniu liczby nie wyswietlało zera
            operacja_wykonana = false;
            Button z = (Button)sender;//pobieranie znaku z buttona
            aktualnie.Text += z.Text;
            //poniżej warunek który pilnuje by przecinek w ciągu znaków był użyty raz
            if (z.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + z.Text;

            }
            else
                textBox1.Text = textBox1.Text + z.Text;//do textBox1 wpisywane bedą ciągiem liczby z wcisnietyh buttonow
        }


        public void dzialanie(object sender, EventArgs e)
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

        public void bwynik_Click(object sender, EventArgs e)
        {
         //po wybraniu znaku zapisanego w "operacja" program na podstawie tych znaków wybierze uzyty znak i obliczy wynik zgodnie z wzorami   
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

        public void Kalkulator_Load(object sender, EventArgs e)
        {

        }

        public void breset_Click(object sender, EventArgs e)
        {
            //użycie przycisku reset powoduje zresetowanie, wyczyszczenie textBox1 zawierającego aktualne działania oraz wyczyszczenie Labela"aktualnie" wyswietlajacego ostatnie działania
            textBox1.Clear();
            textBox1.Text = "0";
            wynik = 0;
            aktualnie.Text = "";

        }

        public void Bpierwiastek_Click(object sender, EventArgs e)
        {
            //obliczanie pierwiastka
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        }

        public void Bpotega_Click(object sender, EventArgs e)
        {
            //obliczanie do potegi 2
            textBox1.Text = (Math.Pow(double.Parse(textBox1.Text),2)).ToString();
        }

        public void Sin_Click(object sender, EventArgs e)
        {
            //obliczanie sin
            textBox1.Text = (Math.Sin(double.Parse(textBox1.Text))).ToString();
        }

        public void Cos_Click(object sender, EventArgs e)
        {
            //obliczanie cos
            textBox1.Text = (Math.Cos(double.Parse(textBox1.Text))).ToString();
        }

        public void Tg_Click(object sender, EventArgs e)
        {
            //obliczanie tan
            textBox1.Text = (Math.Tan(double.Parse(textBox1.Text))).ToString();
        }

        public void potega3_Click(object sender, EventArgs e)
        {
            //obliczanie do potegi 3
            textBox1.Text = (Math.Pow(double.Parse(textBox1.Text), 3)).ToString();
        }

        public void wstecz_Click(object sender, EventArgs e)
        {
            //warunek dla przycisku cofającego ciąg znaków dla ilosci znaków wiekszej niz 1 w textboxie cofa je o jeden z kazdym kliknieciem
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        public void blog_Click(object sender, EventArgs e)
        {
            //obliczanie logarytmu
            textBox1.Text = (Math.Log(double.Parse(textBox1.Text))).ToString();
        }
    }
}
