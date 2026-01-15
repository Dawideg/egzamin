using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Notatka {
        private static int licznik;
        private int id;
        protected string tytul;
        protected string tresc;

        public Notatka(string tytul, string tresc) {
            licznik++;
            id = licznik;   
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void Wypisz() {
            Console.WriteLine(tytul);
            Console.WriteLine(tresc);
        }
        public void Diagnozuj() { 
            Console.WriteLine(licznik +";"+id+";"+tytul+";"+tresc);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notatka notatka = new Notatka("Tytul1", "Tresc Notatki");
            Notatka notatka1 = new Notatka("Tytul1", "Tresc Notatki");

            notatka.Wypisz();
            notatka.Diagnozuj();

            notatka1.Wypisz();
            notatka1.Diagnozuj();


        }
    }
}
