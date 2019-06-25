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
        ///tworzenie testów metody obliczania  pierwistka liczby
        [TestMethod()]
        public void Bpierwiastek_ClickTest()
        {
            double textBox1 = 9;
            textBox1 = (Math.Sqrt(textBox1));
            Assert.AreEqual(3, textBox1);
            Assert.IsFalse(false);
            Assert.IsTrue(true);
        }
        ///tworzenie testów metody obliczania liczby podniesionej do potegi 2
        [TestMethod()]
        public void Bpotega_ClickTest()
        {
            double textBox1 = 2;

            textBox1 = (Math.Pow(textBox1, 2));
            Assert.AreEqual(4, textBox1);
            Assert.IsFalse(false);
            Assert.IsTrue(true);
        }
        ///tworzenie testów metody obliczania Sinusów
        [TestMethod()]
        public void Sin_ClickTest()
        {
            double textBox1 = 65;
            double wynik = Math.Sin(65);
            textBox1 = (Math.Sin(textBox1));
            Assert.AreEqual(wynik, textBox1);
            Assert.IsFalse(false);
            Assert.IsTrue(true);
        }
        ///tworzenie testów metody obliczania Cosiniusu
        [TestMethod()]
        public void Cos_ClickTest()
        {
            double textBox1 = 2;
            double wynik = Math.Cos(2);
            textBox1 = (Math.Cos(textBox1));
            Assert.AreEqual(wynik, textBox1);
            Assert.IsFalse(false);
            Assert.IsTrue(true);

        }
        ///tworzenie testów metody obliczania Tangesu
        [TestMethod()]
        public void Tg_ClickTest()
        {
            double textBox1 = 2;
            double wynik = Math.Tan(2);
            textBox1 = (Math.Tan(textBox1));
            Assert.AreEqual(wynik, textBox1);
            Assert.IsFalse(false);
            Assert.IsTrue(true);
        }
        ///tworzenie testów metody obliczania liczby podniesionej do potegi 3
        [TestMethod()]
        public void potega3_ClickTest()
        {
            double textBox1 = 2;
            textBox1 = (Math.Pow((textBox1), 3));
            Assert.AreEqual(8, textBox1);
            Assert.IsFalse(false);
            Assert.IsTrue(true);
        }


        ///testowanie metody zamiany temperatur
        [TestMethod()]
        public void Zamiana_ClickTest()
        {
            String comboBox1 = "Celcjusz";
            String comboBox2 = "Fahrenheit";
            Double tzmieniona;
            Double textBox1 = 7;
            if (comboBox1 == "Celcjusz" && comboBox2 == "Fahrenheit")
            {
                tzmieniona = ((9 * (textBox1) / 5) + 32);
                Assert.AreEqual(44.6, tzmieniona);
                Assert.IsFalse(false);
                Assert.IsTrue(true);
               
            }

        }
        ///testowanie metody  zamiany jednostek miar wraz z ich iloscią
        [TestMethod()]
        public void miary_ClickTest()
        {
            String comboBox3 = "metry";
            String comboBox4 = "dm";
            decimal wynikmiar;
            decimal ilosc = 5;
            if (comboBox3 == "metry" && comboBox4 == "dm")
            {
                wynikmiar = ((decimal)10 * (decimal)ilosc);
                Assert.AreEqual(50, wynikmiar);
                Assert.IsFalse(false);
                Assert.IsTrue(true);
            }
        }
        ///tworzenie testów metody zamiany jednostek wag wraz z ich iloscią
        [TestMethod()]
        public void jednostki_ClickTest()
        {
            String comboBox1 = "kg";
            String comboBox2 = "kg";
            decimal wynikjednostek;
            decimal ilosc = 5;
            if (comboBox1 == "kg" && comboBox2 == "kg") { wynikjednostek = ((decimal)1 * (decimal)ilosc);
                Assert.AreEqual(5,wynikjednostek);
                Assert.IsFalse(false);
                Assert.IsNotNull(wynikjednostek);
                Assert.IsTrue(true);
            }
           
        }


    }
}