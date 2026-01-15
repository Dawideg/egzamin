using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    
    internal class Program
    {

        public static void WypelnijTablice(int[] tab) { 
            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(1, 100);                
            }
        }

        public static void WyswietlTablice(int[] tab) {
            Console.WriteLine("Tablica:");
            for (int i = 0; i < tab.Length-1; i++) {
                Console.Write(tab[i] + ",");
            }
            Console.WriteLine();
        }

        public static int PrzeszukajTablice(int[] tab, int poszukiwana) {
            tab[59] = poszukiwana;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == poszukiwana && i != tab.Length-1) {
                        return i;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] tablica = new int[60];
            int poszukiwanaLiczba = 0;

            Console.WriteLine("Jaką liczbę chcesz wyszukać?");
            poszukiwanaLiczba = int.Parse(Console.ReadLine());  
            WypelnijTablice(tablica);
            WyswietlTablice(tablica);
            int indeks = PrzeszukajTablice(tablica, poszukiwanaLiczba);
            if (indeks == 0)
            {
                Console.WriteLine("Nie znaleziono podanej liczby");
            }
            else { 
                 Console.WriteLine("Podana liczba znaleziona pod indeksem: " + indeks);
            }
        }
    }
}
