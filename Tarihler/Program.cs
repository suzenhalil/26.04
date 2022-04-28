using System;

namespace Tarihler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime baslangic = DateTime.Now;
            //Günün tarih ve zamanı almak
            Console.WriteLine(DateTime.Now);
            //Sadece gün ay yıl verir
            Console.WriteLine(DateTime.Now.ToShortDateString());
            //Tarih saat ile birlikte gün ismi verir
            Console.WriteLine(DateTime.Now.ToLongDateString());

            //Tarih Formatlama
            Console.WriteLine(DateTime.Now.Month+"/"+DateTime.Now.Day+"/"+DateTime.Now.Year);

            //Artık yıl kontrolu

            bool artikyilmi = DateTime.IsLeapYear(2022);

            //son 10 yılın artık yılını bulunuz
            for (int i = 2000; i < DateTime.Now.Year; i++)
            {
                artikyilmi = DateTime.IsLeapYear(i);
                if (artikyilmi)
                    Console.WriteLine(i);
            }

            //Haftanın Günü
            Console.WriteLine(DateTime.Now.DayOfWeek);
            //Yılın Günü
            Console.WriteLine(DateTime.Now.DayOfYear);
            //Belirli Gün Sonrası
            DateTime trh = DateTime.Now.AddDays(10);
            Console.WriteLine(trh);
            //TimeSpan
            DateTime bora = new DateTime(1994, 9, 13);
            DateTime simdi = DateTime.Now;
            TimeSpan tarihfarki = simdi - bora;
            Console.WriteLine("Bora " + tarihfarki.Days + "gündür yaşıyor.");
            Console.WriteLine("Bora " + tarihfarki.TotalHours+ "saattir yaşıyor.");

            



        }
    }
}
