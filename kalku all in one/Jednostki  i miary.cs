﻿using System;
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
            

            
            if (comboBox3.Text == "metry" && comboBox4.Text == "dm") { wynikmiar.Text = ((decimal)10 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "cm") { wynikmiar.Text = ((decimal)100 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "mm") { wynikmiar.Text = ((decimal)1000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "km") { wynikmiar.Text = ((decimal)0.001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "metry") { wynikmiar.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "mm") { wynikmiar.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "cm") { wynikmiar.Text = ((decimal)0.1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "dm") { wynikmiar.Text = ((decimal)0.01 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "metry") { wynikmiar.Text = ((decimal)0.001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "km") { wynikmiar.Text = ((decimal)0.000001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "mm") { wynikmiar.Text = ((decimal)10 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "cm") { wynikmiar.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "dm") { wynikmiar.Text = ((decimal)0.1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "metry") { wynikmiar.Text = ((decimal)0.01 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "km") { wynikmiar.Text = ((decimal)0.00001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "mm") { wynikmiar.Text = ((decimal)100 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "cm") { wynikmiar.Text = ((decimal)10 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "dm") { wynikmiar.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "metry") { wynikmiar.Text = ((decimal)0.1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "km") { wynikmiar.Text = ((decimal)0.0001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "mm") { wynikmiar.Text = ((decimal)1000000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "cm") { wynikmiar.Text = ((decimal)100000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "dm") { wynikmiar.Text = ((decimal)10000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "metry") { wynikmiar.Text = ((decimal)1000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "km") { wynikmiar.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "metry" && comboBox4.Text == "mile") { wynikmiar.Text = ((decimal)0.00062137 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "km" && comboBox4.Text == "mile") { wynikmiar.Text = ((decimal)0.62137 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "dm" && comboBox4.Text == "mile") { wynikmiar.Text = ((decimal)0.000062137 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "cm" && comboBox4.Text == "mile") { wynikmiar.Text = ((decimal)0.0000062137 * (decimal)ilosc.Value).ToString(); }
            if (comboBox3.Text == "mm" && comboBox4.Text == "mile") { wynikmiar.Text = ((decimal)0.00000062137 * (decimal)ilosc.Value).ToString(); }

        }

        private void jednostki_Click(object sender, EventArgs e)
        {




            if (comboBox1.Text == "kg" && comboBox2.Text == "kg") { wynikjednostek.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "mg") { wynikjednostek.Text = ((decimal)1000000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "tony") { wynikjednostek.Text = ((decimal)0.001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "gram") { wynikjednostek.Text = ((decimal)1000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "funty") { wynikjednostek.Text = ((decimal)2.44192843875 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "kg" && comboBox2.Text == "dekagramy") { wynikjednostek.Text = ((decimal)100 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "mg" && comboBox2.Text == "mg") { wynikjednostek.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "mg" && comboBox2.Text == "tony") { wynikjednostek.Text = ((decimal)0.000000001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "mg" && comboBox2.Text == "gram") { wynikjednostek.Text = ((decimal)0.001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "mg" && comboBox2.Text == "funty") { wynikjednostek.Text = ((decimal)0.00000244192843875 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "mg" && comboBox2.Text == "dekagramy") { wynikjednostek.Text = ((decimal)0.0001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "mg" && comboBox2.Text == "kg") { wynikjednostek.Text = ((decimal)0.000001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "tony" && comboBox2.Text == "kg") { wynikjednostek.Text = ((decimal)1000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "tony" && comboBox2.Text == "mg") { wynikjednostek.Text = ((decimal)1000000000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "tony" && comboBox2.Text == "tony") { wynikjednostek.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "tony" && comboBox2.Text == "gram") { wynikjednostek.Text = ((decimal)1000000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "tony" && comboBox2.Text == "funty") { wynikjednostek.Text = ((decimal)2441.92843875 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "tony" && comboBox2.Text == "dekagramy") { wynikjednostek.Text = ((decimal)100000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "gram" && comboBox2.Text == "kg") { wynikjednostek.Text = ((decimal)0.001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "gram" && comboBox2.Text == "mg") { wynikjednostek.Text = ((decimal)1000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "gram" && comboBox2.Text == "tony") { wynikjednostek.Text = ((decimal)0.000001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "gram" && comboBox2.Text == "gram") { wynikjednostek.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "gram" && comboBox2.Text == "funty") { wynikjednostek.Text = ((decimal)0.00244192843875 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "gram" && comboBox2.Text == "dekagramy") { wynikjednostek.Text = ((decimal)0.1 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "dekagramy" && comboBox2.Text == "kg") { wynikjednostek.Text = ((decimal)0.01 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "dekagramy" && comboBox2.Text == "mg") { wynikjednostek.Text = ((decimal)10000 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "dekagramy" && comboBox2.Text == "tony") { wynikjednostek.Text = ((decimal)0.00001 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "dekagramy" && comboBox2.Text == "gram") { wynikjednostek.Text = ((decimal)10 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "dekagramy" && comboBox2.Text == "funty") { wynikjednostek.Text = ((decimal)0.0244192843875 * (decimal)ilosc.Value).ToString(); }
            if (comboBox1.Text == "dekagramy" && comboBox2.Text == "dekagramy") { wynikjednostek.Text = ((decimal)1 * (decimal)ilosc.Value).ToString(); }

        }

        
    }
}
