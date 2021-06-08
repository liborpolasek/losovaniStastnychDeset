using Microsoft.VisualStudio.TestTools.UnitTesting;
using losovaniStastnychDeset;
using System;
using System.Collections.Generic;
using System.Text;

namespace losovaniStastnychDeset.Tests
{
    [TestClass()]
    public class TahaniCisel1Tests
    {
        [TestMethod()]
        public void getNumbersTest()
        {
            TahaniCisel1 tc = new TahaniCisel1();
            var cislo = tc.getNumbers();

            Assert.IsInstanceOfType(cislo, typeof(List<int>));
        }

        [TestMethod()]
        public void NextNumberTestIfNumber()
        {
            TahaniCisel1 tc = new TahaniCisel1();
            var cislo = tc.NextNumber();

            Assert.IsInstanceOfType(cislo, typeof(int));
        }

        [TestMethod()]
        public void NextNumberTestNumberBetween1and80()
        {
            TahaniCisel1 tc = new TahaniCisel1();
            var cislo = tc.NextNumber();

            Assert.IsTrue(1 >= cislo && cislo <= 80);
        }
    }
}