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
    public partial class konwenter : UserControl
    {
        public konwenter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
           
            string zjakiej, dojakiej,url;
            zjakiej = comboBox1.SelectedItem.ToString();
            dojakiej = comboBox2.SelectedItem.ToString();
            url=("https://www.google.com/search?q="+ilosc+" "+zjakiej+"na+"+dojakiej+"&oq="+ilosc+" "+zjakiej+ "na+" + dojakiej);
            webBrowser1.Navigate(url);
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void konwenter_Load(object sender, EventArgs e)
        {
            
        }
    }
}
