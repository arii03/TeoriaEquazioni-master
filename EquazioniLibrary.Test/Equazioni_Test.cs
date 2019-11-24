using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class Equazioni_Test
    {

        [TestMethod]
        public void TestMethod1()
        {

            double a = 3;
            double b = 4;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
            
            [TestMethod]
        public void TestMethod2()
        {
            double a = 3;
                double b = 4;
                bool risposta2_aspettata = true;
                bool risposta2 = Equazioni.IsInconsisted(a, b);
                Assert.AreEqual(risposta2_aspettata, risposta2);
        }

        [TestMethod]
        public void IsDegree2()
        {
            double a = 0;
            bool risposta_aspettata = true;
            bool risposta2 = Equazioni.IsDegree2(a);
            Assert.AreEqual(risposta_aspettata, risposta2);
        }

        [TestMethod]
        public void Delta()
        {
            double a = 4;
            double b = 8;
            double c = 6;
            double risposta_aspettata = -32;
            double risposta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risposta_aspettata, risposta);
        }

        [TestMethod]
        public void EquationDegree1()
        {
            double a = 4;
            double b = 12;
            double risposta_aspettata = -3;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
    }
}
