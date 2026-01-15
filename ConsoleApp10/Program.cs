namespace ConsoleApp10
{


    internal class Program
    {
        public static void WypelnijTablice(bool[] tablica)
        {
            for (int i = 2; i < tablica.Length; i++) {
                tablica[i] = true;
            }
        }

        public static void Erastotenes(bool[] tablica) {
            for (int i = 2; i < 10; i++) {
                if (tablica[i]) {
                    for (int j = 2*i; j < 100; j = j+i) {
                        tablica[j] = false;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            bool[] tablica = new bool[100];
            WypelnijTablice(tablica);
            Erastotenes(tablica);

            for (int i = 0; i < tablica.Length; i++) {
                if (tablica[i]) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
