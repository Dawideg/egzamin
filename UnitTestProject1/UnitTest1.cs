using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestujDanePodstawowe()
        {
            string tekst = "abc";
            int klucz = 3;

            string wynik = ConsoleApp19.Program.Szyfruj(tekst, klucz);

            Assert.AreEqual("def", wynik);
        }

        [TestMethod]
        public void TestujZawijanie() {
            string tekst = "xyz";
            int klucz = 3;

            string wynik = ConsoleApp19.Program.Szyfruj(tekst, klucz);

            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void TestujOdszyfrowanie() {
            string tekst = "def";
            int klucz = -3;

            string wynik = ConsoleApp19.Program.Szyfruj(tekst, klucz);

            Assert.AreEqual("abc", wynik);
        }
        [TestMethod]
        public void TestujKluczWiekszyNizAlfabet()
        {
            string tekst = "abc";
            int klucz = 29;

            string wynik = ConsoleApp19.Program.Szyfruj(tekst, klucz);

            Assert.AreEqual("def", wynik);
        }
        [TestMethod]
        public void TestujSpacja()
        {
            string tekst = "ab cd";
            int klucz = 2;

            string wynik = ConsoleApp19.Program.Szyfruj(tekst, klucz);

            Assert.AreEqual("cd ef", wynik);
        }
    }

}
