using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        public static int[,] Losuj(int losowania)
        {
            int[,] wyniki = new int[losowania, 6];
            Random rnd = new Random();
            for (int i = 0; i < wyniki.GetLength(0); i++)
            {
                List<int> wylosowano = new List<int>();
                for (int j = 0; j < wyniki.GetLength(1); j++)
                {
                    int liczba;
                    do
                    {
                        liczba = rnd.Next(1, 50);
                    } while (wylosowano.Contains(liczba));
                    wyniki[i, j] = liczba;
                    wylosowano.Add(liczba);
                }
            }
            return wyniki;
        }
        public static void WyswietlWyniki(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                Console.Write("Losowanie " + i + ": ");
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }

        public static void LiczWystapienia(int[,] tab)
        {
            for (int k = 1; k < 50; k++)
            {
                int licznik = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (tab[i, j] == k)
                        {
                            licznik++;
                        }
                    }
                }
                Console.WriteLine("Wystąpienia liczby " + k + ": " + licznik);
                
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerować losowań?");
            int losowania = int.Parse(Console.ReadLine());
            int[,] wyniki = Losuj(losowania);
            WyswietlWyniki(wyniki);
            LiczWystapienia(wyniki);
        }
    }
}
