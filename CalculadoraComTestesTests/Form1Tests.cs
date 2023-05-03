using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraComTestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComTestes.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        [DataRow(1,"1","1",2)]
        [DataRow(2, "1", "1", 0)]
        [DataRow(3, "1", "1", 1)]
        [DataRow(4, "1", "1", 1)]
        [DataRow(1, "8", "2", 10)]
        [DataRow(2, "8", "2", 6)]
        [DataRow(3, "8", "2", 16)]
        [DataRow(4, "8", "2", 4)]
        [DataRow(1, "6", "3", 9)]
        [DataRow(2, "6", "3", 3)]
        [DataRow(3, "6", "3", 18)]
        [DataRow(4, "6", "3", 2)]
        public void CalculaTest(int tipo, string v1, string v2, double res)
        {
            CalculadoraComTestes.Form1 f1 = new CalculadoraComTestes.Form1();

           

            //Act
            double result = f1.Calcula(tipo, v1, v2);

            //Assert
            Assert.AreEqual(res, result);
        }
    }
}