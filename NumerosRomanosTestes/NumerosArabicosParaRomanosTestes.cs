using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Numeros_Romanos;

namespace NumerosRomanosTestes
{
    [TestClass]
    public class NumerosArabicosParaRomanosTestes
                
    {
        [TestMethod]        
        public void RetornaI()
        {
            ConversorArábicos conversor = new ConversorArábicos(1);
            Assert.AreEqual("I", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaIII()
        {
            ConversorArábicos conversor = new ConversorArábicos(3);
            Assert.AreEqual("III", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaIV()
        {
            ConversorArábicos conversor = new ConversorArábicos(4);
            Assert.AreEqual("IV", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaV()
        {
            ConversorArábicos conversor = new ConversorArábicos(5);
            Assert.AreEqual("V", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaVII()
        {
            ConversorArábicos conversor = new ConversorArábicos(7);
            Assert.AreEqual("VII", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaIX()
        {
            ConversorArábicos conversor = new ConversorArábicos(9);
            Assert.AreEqual("IX", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaX()
        {
            ConversorArábicos conversor = new ConversorArábicos(10);
            Assert.AreEqual("X", conversor.nRomano);
        }

        
        [TestMethod]
        public void RetornaXV()
        {
            ConversorArábicos conversor = new ConversorArábicos(15);
            Assert.AreEqual("XV", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaXX()
        {
            ConversorArábicos conversor = new ConversorArábicos(20);
            Assert.AreEqual("XX", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaXL()
        {
            ConversorArábicos conversor = new ConversorArábicos(40); 
            Assert.AreEqual("XL", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaL()
        {
            ConversorArábicos conversor = new ConversorArábicos(50);
            Assert.AreEqual("L", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaLXXIII()
        {
            ConversorArábicos conversor = new ConversorArábicos(73);
            Assert.AreEqual("LXXIII", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaXC()
        {
            ConversorArábicos conversor = new ConversorArábicos(90);
            Assert.AreEqual("XC", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaCXLIX()
        {
            ConversorArábicos conversor = new ConversorArábicos(149);
            Assert.AreEqual("CXLIX", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaCD()
        {
            ConversorArábicos conversor = new ConversorArábicos(400);
            Assert.AreEqual("CD", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaD()
        {
            ConversorArábicos conversor = new ConversorArábicos(500);
            Assert.AreEqual("D", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaCM()
        {
            ConversorArábicos conversor = new ConversorArábicos(900); 
            Assert.AreEqual("CM", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaM()
        {
            ConversorArábicos conversor = new ConversorArábicos(1000);
            Assert.AreEqual("M", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaMD()
        {
            ConversorArábicos conversor = new ConversorArábicos(1500);
            Assert.AreEqual("MD", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaMMM()
        {
            ConversorArábicos conversor = new ConversorArábicos(3000);
            Assert.AreEqual("MMM", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaMMMCII()
        {
            ConversorArábicos conversor = new ConversorArábicos(3102);
            Assert.AreEqual("MMMCII", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaĪV̄()
        {
            ConversorArábicos conversor = new ConversorArábicos(4000);
            Assert.AreEqual("ĪV̄", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaV̄()
        {
            ConversorArábicos conversor = new ConversorArábicos(5000);
            Assert.AreEqual("V̄", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaV̄ĪĪ()
        {
            ConversorArábicos conversor = new ConversorArábicos(7000);
            Assert.AreEqual("V̄ĪĪ", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaĪX̄()
        {
            ConversorArábicos conversor = new ConversorArábicos(9000);
            Assert.AreEqual("ĪX̄", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaĪX̄CXLIX()
        {
            ConversorArábicos conversor = new ConversorArábicos(9149);
            Assert.AreEqual("ĪX̄CXLIX", conversor.nRomano);
        }

        [TestMethod]
        public void RetornaX̄()
        {
            ConversorArábicos conversor = new ConversorArábicos(10000);
            Assert.AreEqual("X̄", conversor.nRomano);
        }
        
    }
}
