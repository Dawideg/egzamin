using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Operacje
    {
        public int[] tablica;

        public Operacje()
        {
            tablica = new int[10];
        }

        public void Sortuj() {
            for (int i = 0; i < tablica.Length-1; i++) {
                for (int j = i + 1; j < tablica.Length; j++) { 
                    if (tablica[j] < tablica[i]) {
                        int temp = tablica[i];
                        tablica[i] = tablica[j];
                        tablica[j] = temp;
                    }
                }
            }
        }

        public void Wyswietl() {
            Console.Write("Tablica: ");
            for (int i = 0; i < tablica.Length; i++) { 
                Console.Write(tablica[i] + ", ");
            }
        }

        private int SzukajMax() {
            int max = 0;    
            for (int i = 0; i < tablica.Length; i++) {
                if (tablica[i] > max)
                {
                    max = tablica[i];
                }
            }
            return max;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacje operacje = new Operacje();

            Console.WriteLine("Wypełnianie tablicy: ");
            for (int i = 0; i < operacje.tablica.Length; i++) {
                Console.Write("Podaj " + i + " element tablicy: ");
                operacje.tablica[i] = int.Parse(Console.ReadLine());
            }
            operacje.Sortuj();
            operacje.Wyswietl();
        }
    }
}
