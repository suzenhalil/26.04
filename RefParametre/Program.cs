using System;

namespace RefParametre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elemanlar = new string[3];

            elemanlar[0] = "ali@gmail.com";
            elemanlar[1] = "veli@gmail.com";
            elemanlar[2] = "ayse@hotmail.com";

            //Console.Write("Mail Adresi: ");
            //string mailAddress = Console.ReadLine();

            MailGonder(ref elemanlar, "ercan@gmail.com");

            //foreach (string eleman in elemanlar)
            //{
            //    Console.WriteLine(eleman);
            //}
        }
        public static void MailGonder(ref string[] mailadresleri, string gonderen)
        {
            foreach (var item in mailadresleri)
            {
                Console.WriteLine(item + " adresinde " + gonderen + "  tarafindan mail gonderilmistir.");
            }
        }
    }
}
