using System;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Wypelnij(int[,] wyniki) {
            Random random = new Random();
            for (int i = 0; i < wyniki.GetLength(0); i++) {
                List<int> wystapienia = new List<int>();
                for (int j = 0; j < wyniki.GetLength(1); j++) {
                    int liczba;
                    do
                    {
                        liczba = random.Next(1, 49);
                    }
                    while (wystapienia.Contains(liczba));
                    
                    wystapienia.Add(liczba);
                    wyniki[i,j] = liczba;
                }
            }
        }
        public static void Wyswietl(int[,] wyniki) {
            for (int i = 0; i < wyniki.GetLength(0); i++)
            {
                int licz = i + 1;
                Console.Write("Losowanie " + licz + ": ");
                for (int j = 0; j < wyniki.GetLength(1); j++)
                {
                    Console.Write(wyniki[i,j] + " ");
                }
                Console.WriteLine();    
            }
        }

        public static void PoliczWystapienia(int[,] wyniki) {
            for (int i = 1; i < 50; i++) {
                int licznik = 0;
                for (int j = 0; j < wyniki.GetLength(0); j++)
                {
                    for (int k = 0; k < wyniki.GetLength(1); k++)
                    {
                        if (wyniki[j, k] == i) { 
                            licznik++;
                        }
                    }
                }

                Console.WriteLine("Wystąpienia liczby " + i + ": " + licznik);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerować losowań?");
            int losowania =  int.Parse(Console.ReadLine());
            int[,] wyniki = new int[losowania,6];
            Wypelnij(wyniki);
            Wyswietl(wyniki);
            PoliczWystapienia(wyniki);
        }
    }
}
