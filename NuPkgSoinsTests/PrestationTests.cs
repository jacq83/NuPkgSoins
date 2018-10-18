using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier.Tests
{
    [TestClass()]
    public class PrestationTests
    {
        [TestMethod()]
        public void SommePourRienTest()
        {

            int a = 3;
            int b = 5;
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(8, unePrestation.SommePourRien(a, b), "La somme doit être égale à 8");
        }

        [TestMethod()]
        public void HeureSoinTest()
        {
            //throw new NotImplementedException();
        }

        [TestMethod()]
        public void CompareToTestEstEgale()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(0, unePrestation.CompareTo(uneAutrePrestation));
        }

        [TestMethod()]
        public void CompareToTestEstSuperieur()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 16, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2015, 9, 14, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(1, unePrestation.CompareTo(uneAutrePrestation));
        }

        [TestMethod()]
        public void CompareToTestEstInferieur()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 4, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(-1, unePrestation.CompareTo(uneAutrePrestation));
        }
    }

}