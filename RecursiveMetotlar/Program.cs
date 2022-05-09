using System;

namespace RecursiveMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecursiveFaktoriyel(3);
            fibanocci(100);


        }
        public static long RecursiveFaktoriyel(int sayi)

        {
            if (sayi == 0)
                return 1;
            else
                return sayi * RecursiveFaktoriyel(sayi - 1);
            
        }
        public static void fibanocci(int sayi)
        {
            decimal[] fib = new decimal[sayi];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < sayi; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
                Console.Write("i= " + i + " =>" + fib[i]);
                Console.WriteLine("  Oran :" + fib[i] / (fib[i - 1]));
            }


        }


    }
}
