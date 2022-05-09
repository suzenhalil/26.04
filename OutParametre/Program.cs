using System;

namespace OutParametre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yakalanan;
            geriyedonendeger(12, out yakalanan);
            Console.WriteLine(yakalanan.ToString());

            int toplamaSonucu;
            int farkSonucu;
            long carpimSonucu;
            double bolumSonucu;
            byte modSonucu;

            Hesapla(9, 4,
                out toplamaSonucu,
                out farkSonucu,
                out carpimSonucu,
                out bolumSonucu,
                out modSonucu);
            Console.WriteLine("Toplam:" + toplamaSonucu);
            Console.WriteLine("Fark:" + farkSonucu);
            Console.WriteLine("Carpim:" + carpimSonucu);
            Console.WriteLine("Bolum:" + bolumSonucu);
            Console.WriteLine("Mod:" + modSonucu);

        }
        public static void geriyedonendeger(int sayi, out double firlatilan)
        {
            firlatilan = Math.Pow(sayi, 2);
        }
        public static void Hesapla(int sayiBir,
            int sayiIki,
            out int toplam,
            out int fark,
            out long carpim,
            out double bolum,
            out byte mod)
        {
            toplam = sayiBir + sayiIki;
            fark = sayiBir - sayiIki;
            carpim = sayiBir * sayiIki;
            bolum = sayiBir / sayiIki;
            mod = (byte)(sayiBir % sayiIki);
        }

    }
}
