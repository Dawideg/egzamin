namespace ConsoleApp5
{

    public class Urzadzenie {
        public void WyswietlKomunikat(string komunikat) {
            Console.WriteLine(komunikat);
        }
    }

    public class Odkurzacz : Urzadzenie {
        private bool czyWlaczony = false;

        public void on() {
            if (czyWlaczony == false) { 
            this.czyWlaczony = true;
            WyswietlKomunikat("Odkurzacz włączono");
            }
        }
        public void off()
        {
            if (czyWlaczony == true) { 
            this.czyWlaczony = false;
            WyswietlKomunikat("Odkurzacz wyłączono");
            }
        }
    }

    public class Pralka : Urzadzenie {
        private int numerProgramu = 0;

        public int UstawNumerProgramu(int numer) {
            if (numer >= 1 && numer <= 12)
            {
                this.numerProgramu = numer;
                WyswietlKomunikat("Program został ustawiony");
            }
            else { 
                this.numerProgramu = 0;
                WyswietlKomunikat("Podano niepoprawny numer programu");

            }
            return numerProgramu;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pralka pralka = new Pralka();
            Odkurzacz odkurzacz = new Odkurzacz();


            Console.WriteLine("Podaj numer prania 1..12");
            int pranie = int.Parse(Console.ReadLine());
            pralka.UstawNumerProgramu(pranie);

            odkurzacz.on();
            odkurzacz.on();
            odkurzacz.on();
            odkurzacz.WyswietlKomunikat("Odkurzacz wyładował się");
            odkurzacz.off();
        }
    }
}
