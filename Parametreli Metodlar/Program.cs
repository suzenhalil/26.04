using System;

namespace Parametreli_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AsalSayi();

        }

        static void EkranaYazdir(string mesaj)
        {
            foreach (char harf in mesaj)
            {
                Console.WriteLine(harf);

            }
        }
        #region Turkce
        public static void TurkceHarfSayisi(string str)
        {
            char[] turkceharfler = { 'ç', 'ı', 'ğ', 'ş', 'ö', 'ü' };

        }
        #endregion

        #region ÖRnek 1

        // rastgele şifre üreten metod yazınız.
        // en az 1 büyük harf
        // en az 1 sayı
        // en az 8 karakter

        static void Sifre()
        {

            Random rastgele = new Random();
            string harfler = "ABCDEFGHIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz1234567890";
            string uret = "";
            for (int i = 0; i < 9; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            Console.WriteLine(uret);
            


        }

        #endregion

        #region Örnek 2

        // verilen sayının asal sayı mı?
        static void AsalSayi()
        {
            Console.WriteLine("Sayı Giriniz.");
            int kontrol = 0;
            int girdi = Convert.ToInt32(Console.ReadLine());
            for (int i =2; i < girdi; i++)
            {
                if (girdi% i  == 0)
                {
                    kontrol++;
                    break;
                }
            }
            if (kontrol != 0)
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı asal sayıdır.");
            }
        }
        #endregion


    }
}
