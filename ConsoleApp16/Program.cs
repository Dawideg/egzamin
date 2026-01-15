using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        public static void Sortuj(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++) {
                for (int j = 0; j < tab.Length-1; j++) {
                    if (tab[j] > tab[j + 1]) {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }
        public static void Wypelnij(int[] tab) {
            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++) {
                tab[i] = rnd.Next(1000);
            }
        } 
        public static void Wypisz(int[] tab) {
            for (int i = 0; i < tab.Length; i++) { 
                Console.Write(tab[i]+", ");
            }
        }
        static void Main(string[] args)
        {
            int[] tablica = new int[100];

            Wypelnij(tablica);
            Sortuj(tablica);
            Wypisz(tablica);

         }
    }
}
