namespace ConsoleApp11
{
    internal class Program
    {

        public static UInt32 NWD(UInt32 a, UInt32 b) {
            while (a != b) {
                if (a > b)
                {
                    a = a - b;
                }
                else {
                    b = b - a;
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź pierwszą liczbę: ");
            UInt32 a = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź drugą liczbę: ");
            UInt32 b = UInt32.Parse(Console.ReadLine());

           Console.WriteLine("Największy wspólny dzielnik liczb to: " + NWD(a, b));
        }
    }
}
