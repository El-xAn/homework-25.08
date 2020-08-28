using System;

namespace HW_25_4
{
    class Program
    {
        static int interval(int a, int b)
        {
            if (a > b)
            {
                int c;
                c = a;
                a = b;
                b = a;
            }
            if (a == b)
            {
                return b;
            }
            else 
            {
                return a + interval(a + 1, b);
            }  
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vvodite 1oe cislo:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvodite 2oe cislo:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Summa cisel diapazona mejdu nimi: {interval(a + 1, b - 1)}");
        }  
            
    }
}
