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
    public partial class Temperatura : UserControl
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        public void Zamiana_Click(object sender, EventArgs e)
        {
            //przeliczanie wartosci temperatur przy uzyciu instrukcji warunkowej
            if (comboBox1.Text == "Celcjusz" && comboBox2.Text == "Fahrenheit") { tzmieniona.Text = ((9 * Double.Parse(textBox1.Text) / 5) + 32).ToString(); }
            if (comboBox1.Text == "Celcjusz" && comboBox2.Text == "Kelvin") { tzmieniona.Text = ( Double.Parse(textBox1.Text)  + 273.15).ToString(); }
            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Celcjusz") { tzmieniona.Text = ((( Double.Parse(textBox1.Text) - 32) * 5)/9).ToString(); }
            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Kelvin") { tzmieniona.Text = ((( Double.Parse(textBox1.Text) + 459.67) *5)/9).ToString(); }
            if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Celcjusz") { tzmieniona.Text = (Double.Parse(textBox1.Text) - 273.15).ToString(); }
            if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Fahrenheit") { tzmieniona.Text = ((9 * Double.Parse(textBox1.Text) / 5) - 459.67).ToString(); }
            if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Kelvin") { tzmieniona.Text = ("to ta sama temperatura").ToString(); }
            if (comboBox1.Text == "Celcjusz" && comboBox2.Text == "Celcjusz") { tzmieniona.Text = ("to ta sama temperatura").ToString(); }
            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Fahrenheit") { tzmieniona.Text = ("to ta sama temperatura").ToString(); }

        }

        private void Temperatura_Load(object sender, EventArgs e)
        {

        }
    }
}
