namespace ConsoleApp3
{
    internal class Program
    {
        public static string Szyfruj(string tekst, int k) {
            string szyfr = "";
            for (int i = 0; i < tekst.Length; i++) {
                if (tekst[i] == ' ')
                {
                    szyfr += tekst[i];
                }
                else { 
                int kod = tekst[i];
                kod += k;
                    if (kod < 97) {
                        kod += 26;
                    }
                    else if(kod > 122) {
                        kod -= 26;
                    }
                    char litera = (char)kod;
                szyfr += litera;
                }
            }
            return szyfr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst do zaszyfrowania: ");
            string tekst = Console.ReadLine();
            Console.WriteLine("Podaj klucz: ");
            int klucz = int.Parse(Console.ReadLine());
            Console.WriteLine("Zaszyfrowany tekst: " + Szyfruj(tekst, klucz));
        }
    }
}
