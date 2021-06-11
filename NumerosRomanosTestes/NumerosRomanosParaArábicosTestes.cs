using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeros_Romanos;

namespace NumerosRomanosTestes
{
    [TestClass]
    public class NumerosRomanosParaArábicosTestes 
    {
        [TestMethod]
        public void Retorna1()
        {
            ConversorRomanos conversor = new ConversorRomanos("I");
            Assert.AreEqual(1, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna4()
        {
            ConversorRomanos conversor = new ConversorRomanos("IV");
            Assert.AreEqual(4, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna5()
        {
            ConversorRomanos conversor = new ConversorRomanos("V");
            Assert.AreEqual(5, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna8()
        {
            ConversorRomanos conversor = new ConversorRomanos("VIII");
            Assert.AreEqual(8, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna9()
        {
            ConversorRomanos conversor = new ConversorRomanos("IX");
            Assert.AreEqual(9, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna10()
        {
            ConversorRomanos conversor = new ConversorRomanos("X");
            Assert.AreEqual(10, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna40()
        {
            ConversorRomanos conversor = new ConversorRomanos("XL");
            Assert.AreEqual(40, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna62()
        {
            ConversorRomanos conversor = new ConversorRomanos("LXII");
            Assert.AreEqual(62, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna90()
        {
            ConversorRomanos conversor = new ConversorRomanos("XC");
            Assert.AreEqual(90, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna100()
        {
            ConversorRomanos conversor = new ConversorRomanos("C");
            Assert.AreEqual(100, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna158()
        {
            ConversorRomanos conversor = new ConversorRomanos("CLVIII");
            Assert.AreEqual(158, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna400()
        {
            ConversorRomanos conversor = new ConversorRomanos("CD");
            Assert.AreEqual(400, conversor.nArabico);
        }       

        [TestMethod]
        public void Retorna500()
        {
            ConversorRomanos conversor = new ConversorRomanos("D");
            Assert.AreEqual(500, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna900()
        {
            ConversorRomanos conversor = new ConversorRomanos("CM");
            Assert.AreEqual(900, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna1000()
        {
            ConversorRomanos conversor = new ConversorRomanos("M");
            Assert.AreEqual(1000, conversor.nArabico);
        } 

        [TestMethod]
        public void Retorna1120()
        {
            ConversorRomanos conversor = new ConversorRomanos("MCXX");
            Assert.AreEqual(1120, conversor.nArabico);
        }
        
        [TestMethod]
        public void Retorna5000()
        {
            ConversorRomanos conversor = new ConversorRomanos("V̄");
            Assert.AreEqual(5000, conversor.nArabico);
        }

        [TestMethod]
        public void Retorna10000()
        {
            ConversorRomanos conversor = new ConversorRomanos("X̄");
            Assert.AreEqual(10000, conversor.nArabico);
        }
    }
}
