namespace ConsoleApp7
{
    public static class StringActions {
        public static int PoliczSamogloski(string tekst) { 
            List<char> samogloski = ['a','ą','e','ę','i','o','u','ó','y','A','Ą','E','Ę','I','O','U','Ó','Y'];
            int licznik = 0;
            if (tekst.Length == 0 || tekst == null) { 
                return 0;
            }
            for (int i = 0; i < tekst.Length; i++) {
                if (samogloski.Contains(tekst[i])) { 
                    licznik++;
                }
            }
            return licznik;
        }

        public static string UsunPowtorzenia(string tekst) {
            string lancuch = "";
            if (tekst.Length == 0 || tekst == null)
            {
                return "";
            }
            for (int i = 0; i < tekst.Length-1; i++)
            {
                if (tekst[i] != tekst[i +1]) {
                    lancuch += tekst[i];
                }
            }
            return lancuch += tekst[tekst.Length-1];
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj łańcuch znaków: ");
            string tekst = Console.ReadLine();

            Console.WriteLine("Liczba samogłosek: " + StringActions.PoliczSamogloski(tekst));
            Console.WriteLine("Łańcuch znaków po usunięciu powtórzeń: " + StringActions.UsunPowtorzenia(tekst));
            
        }
    }
}
