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
    public partial class Jednostki__i_miary : UserControl
    {
        String combobox1="", combobox2="";

        public int metry { get; private set; }

        public Jednostki__i_miary()
        {
            InitializeComponent();
        }
        public void Jednostki()
        {
           
        }

        private void wynikjednostek_Click(object sender, EventArgs e)
        {
            


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox1 = comboBox1.Text;
        }
       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox2 = comboBox2.Text;
        }

        private void miary_Click(object sender, EventArgs e)
        {
            double dm = 10, metry = 1,km=0.001;

            dm = 10;
            metry = 1;
            if (comboBox3.Text == "metry" && comboBox4.Text == "dm") { wynikmiar.Text = (10 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "cm") { wynikmiar.Text = (100 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "mm") { wynikmiar.Text = (1000 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "km") { wynikmiar.Text = (km * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "metry") { wynikmiar.Text = (1 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "mm") { wynikmiar.Text = (1 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "cm") { wynikmiar.Text = (0.1 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "dm") { wynikmiar.Text = (0.01 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "metry") { wynikmiar.Text = (0.001 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "km") { wynikmiar.Text = (0.000001 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "mm") { wynikmiar.Text = (10 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "cm") { wynikmiar.Text = (1 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "dm") { wynikmiar.Text = (0.1 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "metry") { wynikmiar.Text = (0.01 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "km") { wynikmiar.Text = (0.00001 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "mm") { wynikmiar.Text = (100 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "cm") { wynikmiar.Text = (10 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "dm") { wynikmiar.Text = (1 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "metry") { wynikmiar.Text = (0.1 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "km") { wynikmiar.Text = (0.0001 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "mm") { wynikmiar.Text = (1000000 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "cm") { wynikmiar.Text = (100000 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "dm") { wynikmiar.Text = (10000 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "metry") { wynikmiar.Text = (1000 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "km") { wynikmiar.Text = (1 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "mile") { wynikmiar.Text = (0.00062137 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "mile") { wynikmiar.Text = (0.62137 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "mile") { wynikmiar.Text = (0.000062137 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "mile") { wynikmiar.Text = (0.0000062137 * (double)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "mile") { wynikmiar.Text = (0.00000062137 * (double)ilosc.Value).ToString(); }

        }

        private void jednostki_Click(object sender, EventArgs e)
        {
            
            double gramy, dekagramy, kg, tony, mg, funty, wynik;
            
            

            if (comboBox1.Text == "kg" && comboBox2.Text == "mg") { wynikjednostek.Text = (1000000 * (double)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "tony") { wynikjednostek.Text = (0.001 * (double)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "gram") { wynikjednostek.Text = (1000 * (double)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "funty") { wynikjednostek.Text = (2.44192843875 * (double)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "dekagramy") { wynikjednostek.Text = (100 * (double)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "mg") { wynikjednostek.Text = (1000000 * (double)ilosc.Value).ToString(); }


        }

        
    }
}
