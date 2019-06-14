using kalku_all_in_one;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kalku_all_in_one.Tests
{
    [TestClass()]
    public class UnitTest1
    {


        [TestMethod()]
        public void Bpierwiastek_ClickTest1()
        {

        }

        [TestMethod()]
        public void Bpotega_ClickTest()
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
        //testowanie metody potegi
        [TestMethod()]
        public void potega3_ClickTest()
        {
            double textBox1 = 7;
            textBox1 = (Math.Pow((textBox1), 3));
        }

        
    }
}

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
 

        }
        //testowanie pierwiastkow
        [TestMethod]
        public void Test1()
        {

            double textBox1 = 9;
            textBox1 = (Math.Sqrt( textBox1));




        }


    }
}
