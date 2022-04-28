using System;

namespace HazırMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OrnekCompare();
            //OrnekStartWith();
            //OrnekIndexOf();
            //OrnekRemove();
            //OrnekReplace();
            //OrnekSplit();
            //OrnekInsert();
            //OrnekToUpperToLower();
            //OrnekToCharArray();
            //OrnekTrim();
            //OrnekSubString();

        }

        private static void OrnekSubString()
        {
            //1. Kullanım
            string ornekmetin = "Bugün hava çok güzel";
            string yenimetin = ornekmetin.Substring(5);
            Console.WriteLine(yenimetin);
            //2. Kullanım
            Console.WriteLine(ornekmetin.Substring(6, 4));
        }

        private static void OrnekTrim()
        {
            string ornekmetin = "         Bugün hava çok güzel";
            Console.WriteLine(ornekmetin.Trim());
        }

        private static void OrnekToCharArray()
        {
            string ornekmetin = "Bugün hava çok güzel";
            char[] harfler = ornekmetin.ToCharArray();
            foreach (var harf in harfler)
            {
                Console.WriteLine(harf);
            }
        }

        private static void OrnekToUpperToLower()
        {
            string ornekmetin = "Bugün hava çok güzel";
            Console.WriteLine(ornekmetin.ToLower());
            Console.WriteLine(ornekmetin.ToUpper());
        }

        private static void OrnekInsert()
        {
            string ornekmetin = "Bugün hava çok güzel";
            string yenimetin = ornekmetin.Insert(11, "çok ");
            Console.WriteLine(yenimetin);
        }

        private static void OrnekSplit()
        {
            string ornekmetin = "As we started to use [Stack Overflow for Teams] and " +
                "saw how nice it was to have a repository of information, we started " +
                "to see it spread to other teams. Our customer support team started using it," +
                " our people success team started using it, next thing we knew, we had [Slack] " +
                "integrations all over the place.";
            string[] cumleler = ornekmetin.Split(".");
            foreach (string cumle in cumleler)
            {
                Console.WriteLine(cumle);
                string[] kelimeler = cumle.Split(" ");
                foreach (string kelime in kelimeler)
                {
                    Console.WriteLine(kelime);
                }
            }
        }

        private static void OrnekReplace()
        {
            string ornekmetin = "Bugün hava çok güzel";
            string yenimetin = ornekmetin.Replace("güzel", "berbat");
            Console.WriteLine(ornekmetin);
            Console.WriteLine(yenimetin);
        }

        private static void OrnekRemove()
        {
            string ornekmetin = "Bugün hava çok güzel";
            string yenimetin = ornekmetin.Remove(5);
            Console.WriteLine(ornekmetin);
            Console.WriteLine(yenimetin);
            yenimetin = ornekmetin.Remove(5, 5);
            Console.WriteLine(yenimetin);


        }

        private static void OrnekIndexOf()
        {
            string ornekmetin = "Bugün hava çok güzel";

            int index = ornekmetin.IndexOf('u');
            Console.WriteLine("Index Numarası :" + index);
            index = ornekmetin.LastIndexOf('a');
            Console.WriteLine("LastIndex Numarası :" + index);

        }

        public static void OrnekStartWith()
        {
            string girdi = Console.ReadLine();
            bool result = girdi.StartsWith("bil");
            if (result)
            {
                Console.WriteLine("bil ile başlıyor.");
            }
            else
            {
                Console.WriteLine("başlamamaktadır.");
            }
        }

        private static void OrnekCompare()
        {
            string kelime = Console.ReadLine();
            int sonuc = kelime.CompareTo("bilgeadam");

            string mesaj = "";
            switch (sonuc)
            {
                case -1:
                    mesaj = "eksik karakter var";
                    break;
                case 0:
                    mesaj = "tebrikler";
                    break;
                case 1:
                    mesaj = "fazla karakter var";
                    break;
                default:
                    break;

            }
            Console.WriteLine(mesaj);
        }
    }
}
