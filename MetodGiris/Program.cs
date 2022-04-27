using System;

namespace MetodGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = Topla(3, 5);
            Console.WriteLine(toplam);
            EkranaYaz("hellooooooooooo");
            Console.WriteLine("Hello World!");
        }
        public static void EkranaYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        public static int Topla(int sayi1,int sayi2)
            {
                return sayi1 + sayi2;
            }
        
        public static int Topla(float sayi1, int sayi2)
            {
            return ((int)(sayi1 + sayi2));
            }
        public static string Topla(string a,string b)
            {
            return a + b; 
            }
    }
}
