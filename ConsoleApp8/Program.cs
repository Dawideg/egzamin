namespace ConsoleApp8
{
    public class Film {
        protected string tytul;
        protected int liczbaWypozyczen;

        public Film()
        {
            this.tytul = string.Empty;
            this.liczbaWypozyczen = 0;
        }
        public void SetTytul(string tytul) { 
            this.tytul = tytul;
        }
        public string GetTytul() { 
            return this.tytul;
        }
        public int GetLiczbaWypozyczen() {
            return this.liczbaWypozyczen;
        }

        public void IncrementLiczbaWypozyczen() { 
            liczbaWypozyczen += 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();
            Console.WriteLine(film.GetTytul());
            Console.WriteLine(film.GetLiczbaWypozyczen());

            film.SetTytul("Tytuł1");
            Console.WriteLine(film.GetTytul());

            Console.WriteLine("Wartość przed inkrementacją: " + film.GetLiczbaWypozyczen());
            film.IncrementLiczbaWypozyczen();
            Console.WriteLine("Wartość po inkrementacji: " + film.GetLiczbaWypozyczen());


        }
    }
}
