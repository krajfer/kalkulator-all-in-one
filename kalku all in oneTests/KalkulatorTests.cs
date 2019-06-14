using Microsoft.VisualStudio.TestTools.UnitTesting;
using kalku_all_in_one;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalku_all_in_one.Tests
{
    [TestClass()]
    public class KalkulatorTests
    {
        [TestMethod()]
        public void wstecz_ClickTest()
        {

        }

        [TestMethod()]
        public void KalkulatorTest()
        {

        }

        [TestMethod()]
        public void pobieranieznakowTest()
        {

        }

        [TestMethod()]
        public void dzialanieTest()
        {

        }

        [TestMethod()]
        public void bwynik_ClickTest()
        {

        }

        [TestMethod()]
        public void Kalkulator_LoadTest()
        {

        }

        [TestMethod()]
        public void breset_ClickTest()
        {

        }

        [TestMethod()]
        public void Bpierwiastek_ClickTest()
        {

        }

        [TestMethod()]
        public void Bpotega_ClickTest()
        {

        }

        [TestMethod()]
        public void Sin_ClickTest()
        {

        }

        [TestMethod()]
        public void Cos_ClickTest()
        {

        }

        [TestMethod()]
        public void Tg_ClickTest()
        {

        }

        [TestMethod()]
        public void potega3_ClickTest()
        {

        }

        [TestMethod()]
        public void wstecz_ClickTest1()
        {

        }

        [TestMethod()]
        public void blog_ClickTest()
        {

        }
        //testowanie metody zamiany temperatur
        [TestMethod()]
        public void Zamiana_ClickTest()
        {
            String comboBox1 = "Celcjusz";
            String comboBox2 = "Fahrenheit";
            Double tzmieniona;
            Double textBox1 = 7;
            if (comboBox1 == "Celcjusz" && comboBox2 == "Fahrenheit") { tzmieniona = ((9 * (textBox1) / 5) + 32); }
        }
        //testowanie metody miar
        [TestMethod()]
        public void miary_ClickTest()
        {
            String comboBox3 = "metry";
            String comboBox4 = "dm";
            decimal wynikmiar;
            decimal ilosc = 5;
            if (comboBox3 == "metry" && comboBox4 == "dm") { wynikmiar = ((decimal)10 * (decimal)ilosc); }
        }

        [TestMethod()]
        public void jednostki_ClickTest()
        {

        }
    }
}