namespace ConsoleApp9
{
    internal class Program
    {

        /************************************************
        nazwa: LosujOczka
        opis: Funkcja losuje oczka kostek (1-6) tyle razy ile podano w jej argumencie i zapisuje je do tablicy
        parametry: liczbaRzutow - określa ile razy ma być przeprowadzone losowanie
        zwracany typ i opis: List<int> - zwracana jest lista wylosowanych wartości
        autor: 000000000
        ************************************************/
        public static List<int> LosujOczka(int liczbaRzutow)
        {
            Random rand = new Random();
            List<int> rzuty = new List<int>();
            for (int i = 0; i < liczbaRzutow; i++)
            {
                int rzut = rand.Next(1, 6);
                rzuty.Add(rzut);
                Console.WriteLine("Kostka " + (i + 1) + ": " + rzut);
            }
            return rzuty;
        }

        public static int LiczPunkty(List<int> rzuty)
        {
            int suma = 0;
            List<int> wykorzystane = new List<int>();
            for (int i = 0; i < rzuty.Count; i++)
            {
                int szukana = rzuty[i];
                if (!wykorzystane.Contains(szukana))
                {
                    wykorzystane.Add(szukana);
                    int licznik = 0;
                    for (int j = 0; j < rzuty.Count; j++)
                    {
                        if (rzuty[j] == szukana)
                        {
                            licznik++;
                        }
                    }
                    if (licznik > 1)
                    {
                        suma += licznik * szukana;
                    }
                }
            }
            return suma;
        }
        static void Main(string[] args)
        {
            int liczba = 0;
            do
            {
                Console.WriteLine("Ile kostek chcesz rzucić?");
                liczba = int.Parse(Console.ReadLine());
            } while (liczba < 3 || liczba > 10);

            var rzuty = LosujOczka(liczba);
            Console.WriteLine(LiczPunkty(rzuty));
        }
    }
}
