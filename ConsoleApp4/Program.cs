namespace ConsoleApp4
{
    public class Tablica {
        private int[] tab;
        private int liczbaElementow;

        public Tablica(int liczbaElementow)
        {
            this.liczbaElementow = liczbaElementow;
            Random rand = new Random();
            tab = new int[liczbaElementow];
            for (int i = 0; i < liczbaElementow; i++)
            {
                tab[i] = rand.Next(1,1000);
            }
        }

        public void WyswietlElementy() { 
            for(int i = 0;i < liczbaElementow; i++)
            {
                Console.WriteLine(i+": " + tab[i]);
            }
        }

        public int SzukajWartosci(int liczba) {
            for (int i = 0; i < liczbaElementow; i++)
            {
                if (tab[i] == liczba) {
                    Console.WriteLine("Wartość " + liczba + " znaleziona na indeksie " + i);
                    return i;
                }
            }
            return -1;
        }

        public int SzukajNieparzystych() {
            int licznik = 0;
            Console.WriteLine("Liczby nieparzyste: ");
            for (int i = 0; i < liczbaElementow; i++)
            {
                if (tab[i] % 2 != 0) {
                    Console.WriteLine(tab[i]);
                    licznik++;
                }
            }
            Console.WriteLine("Razem nieparzystych: " + licznik);
            return licznik;
        }

        public decimal PoliczSrednia() {
            int suma = 0;
            for (int i = 0; i < liczbaElementow; i++)
            {
                suma += tab[i];
            }
            int srednia = suma /tab.Length;
            Console.WriteLine("Średnia wszystkich elementów: " + srednia);
            return srednia;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica tab1 = new Tablica(500);
            tab1.WyswietlElementy();
            tab1.SzukajWartosci(952);
            tab1.SzukajNieparzystych();
            tab1.PoliczSrednia();


        }
    }
}
