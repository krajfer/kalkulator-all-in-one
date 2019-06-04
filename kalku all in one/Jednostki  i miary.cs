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
        public Jednostki__i_miary()
        {
            InitializeComponent();
        }

        private void wynikjednostek_Click(object sender, EventArgs e)
        {
            


        }

        private void jednostki_Click(object sender, EventArgs e)
        {
            double gramy, dekagramy, kg, tony, mg, funty,wynik;

            kg = 1;
            mg = 0.000001 * kg;
            tony = 1000 * kg;
            gramy = 0.001 * kg;
            funty = 0.45359 * kg;
            dekagramy = 0.01 * kg;

            


        }
    }
}
