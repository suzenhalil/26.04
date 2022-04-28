using System;

namespace MatematikMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Abs(-27));
            //Yuvarlama : Floor => verilen sayıyı bir alt değere yuvarlar.
            Console.WriteLine(Math.Floor(12.9));
            //Yuvarlama : Ceiling
            Console.WriteLine(Math.Ceiling(13.1));
            //Round => sayı yarıdan fazla ise yukarı, aşağı ise aşağı yuvarlar
            Console.WriteLine(Math.Round(12.55));
            Console.WriteLine(Math.Round(12.45));
            Console.WriteLine(Math.Round(12.50));
            Console.WriteLine(Math.Round(13.55));
            //*****Her zaman çift sayıya gider

            //Truncate => virgülden sonrasını almaz
            Console.WriteLine(Math.Truncate(22.55));
            //Maxvalue
            Console.WriteLine(Math.Max(22, 51));
            //Minvalue
            Console.WriteLine(Math.Min(22, 51));

        }
    }
}
