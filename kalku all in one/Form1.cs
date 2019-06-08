using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalku_all_in_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            kalkulator1.Hide();
            jednostki__i_miary1.Hide();
            konwenter1.Hide();
        }

   

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void konwenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void jednostkiIMiaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kalkulatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            jednostki__i_miary1.Hide();
            konwenter1.Hide();

            kalkulator1.Show();
            kalkulator1.BringToFront();
        }

        private void konwenterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kalkulator1.Hide();
            jednostki__i_miary1.Hide();

            konwenter1.Show();
            konwenter1.BringToFront();
        }

        private void jednostkiIMiaryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            kalkulator1.Hide();
            konwenter1.Hide();

            jednostki__i_miary1.Show();
            jednostki__i_miary1.BringToFront();
        }

        private void kalkulator1_Load(object sender, EventArgs e)
        {

        }

        private void wyjscieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
