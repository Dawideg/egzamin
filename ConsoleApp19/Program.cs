using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
   
    public class Program
    {
        public static string Szyfruj(string tekst, int klucz)
        {
            string szyfr = "";
            for (int i = 0; i < tekst.Length; i++) {
                if (tekst[i] != ' ') { 
                int kod = tekst[i];
                kod = kod + klucz;
                if (kod > 122) kod -= 26;
                if (kod < 97) kod += 26;
                szyfr += (char) kod;   
                }else szyfr += tekst[i];
            }
            Console.WriteLine(szyfr);
            return szyfr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst: ");
            string tekst = Console.ReadLine();
            Console.WriteLine("Podaj klucz: ");
            int klucz = int.Parse(Console.ReadLine());
            Szyfruj(tekst, klucz);
        }
    }
}
