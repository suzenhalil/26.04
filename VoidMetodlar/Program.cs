using System;

namespace VoidMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TekCift();
            AlanCevre();
            Ortalama();
        }
        #region Metod 1
        static void TekCift()
        {
            int TekToplam = 0, CiftToplam = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i%2 == 0)
                {
                    CiftToplam += i;
                }
                else
                {
                    TekToplam += i;
                }
            }
            Console.WriteLine("Tek Toplam: " + TekToplam);
            Console.WriteLine("Cift Toplam: " + CiftToplam);

        }
        #endregion

        #region Metod 2

        static void AlanCevre()
        {
            Console.WriteLine("Kısa Kenarı Giriniz: ");
            int kisa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun Kenarı Giriniz: ");
            int uzun = Convert.ToInt32(Console.ReadLine());

            int Cevre = 2*(kisa + uzun);
            int Alan = kisa * uzun;

            Console.WriteLine("Cevre: " + Cevre);
            Console.WriteLine("Alan: " + Alan);

        }

        #endregion

        #region Metod 3

        static void Ortalama()
        {
            Console.WriteLine("1. Vize Notunu Giriniz: ");
            int vize1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Vize Notunu Giriniz: ");
            int vize2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notunu Giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());

            float Ort = (vize1 + vize2) / 2 * 0.3f + final * 0.7f;

            Console.WriteLine("Ortalamanız: " + Ort);

        }

        #endregion
    }
}
