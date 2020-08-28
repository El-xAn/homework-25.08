using System;

namespace HW_25_1
{
    class Program
    {
        static int step(int n)
        {
            int a = 2;
            
            for (int i = 2; i <= n; i++)
            {
                a = a * 2;                              
            }
            return a;
        }

        static int sum(int n)
        {
            int summa = 0;
            if (n>=2)
            {
                summa = step(n) + sum(n - 1);                               
            } 
            return summa;
        }   
        static void Main(string[] args)
        {
            Console.WriteLine(sum(10));
        }
    }
}
