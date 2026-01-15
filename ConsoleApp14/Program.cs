using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Osoba {
        private int id;
        private string imie;
        public static int licznik = 0;

        public Osoba()
        {
            id = 0;
            imie = "";
            licznik++;
        }

        public Osoba(string imie, int id) { 
            this.imie = imie;
            this.id = id;
            licznik++;
        }

        public Osoba(Osoba osoba) { 
            this.id=osoba.id;
            this.imie=osoba.imie;
            licznik++;
        }

        public void Wypisz(string noweImie) {
            if (imie.Length > 0)
            {
                Console.WriteLine("Cześć " + noweImie + ", mam na imię " + imie);
            }
            else {
                Console.WriteLine("Brak danych");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.licznik);
            Osoba osoba = new Osoba();
            Osoba osoba1 = new Osoba("Adam",1);
            Osoba osoba2 = new Osoba(osoba1);

            osoba.Wypisz("Jan");
            osoba1.Wypisz("Jan");
            osoba2.Wypisz("Jan");
            Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.licznik);


        }
    }
}
