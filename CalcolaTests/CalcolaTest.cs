using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcolaLibrary;

namespace CalcolaTests
{
    [TestClass]
    public class CalcolaTest
    {
        [TestMethod]
        public void RaddoppiaTest()
        {
            double numero = 0;
            double Risposta_Aspettata = 0;
            double Risposta_Effettiva = Calcola.Raddoppia(numero);
            Assert.AreEqual(Risposta_Aspettata, Risposta_Effettiva);
        }
        [TestMethod]
        public void SommaMoneteTest()
        {
            double[] Array_Monete = new double[5] { 20, 30, 5, 2, 4 };
            double Somma_Aspettata = 61;
            double Somma_Ricevuta = Calcola.SommaMonete(Array_Monete);
            Assert.AreEqual(Somma_Aspettata, Somma_Ricevuta);
        }
    }
}
