using System;
using System.Collections;
using System.Collections.Generic;

namespace _26._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array.indexOf()
            //dizide aradimiz elemanin index numarasini bize doner
            //Eger Aradimiz elaman dizide yoksa -1 döner.
            // Eger aranan eleman birden fazla olursa ilk buludugu
            // index degerini döner

            //string[] arabalar = { "Bmw", "Audi", "Fiat", "Toyota", "Honda", "Alfa Romeo", "Subaru" };
            //Console.WriteLine("Aradığınız Araç?");
            //string arananaraba = Console.ReadLine();
            //int index = Array.IndexOf(arabalar, arananaraba);
            //// 1. Parametre kaynak dizi 
            //// 2. Parametre Aranacak olan deger. Burada tip onemli. Dikkat 

            //if (index == -1)
            //{
            //    Console.WriteLine("Aradığınız " + arananaraba + "Listede yoktur.");
            //}
            //else
            //{
            //    Console.WriteLine("Aradığınız " + arananaraba + " " + index + ". sıradadır.");
            //}
            //index = Array.IndexOf(arabalar, arananaraba, 2);
            //burada arama işlemi 2. parametreden başlar.

            #endregion

            #region Array.Reverse

            //string[] arabalar = { "Bmw", "Audi", "Fiat", "Toyota", "Honda", "Alfa Romeo", "Subaru" };
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////Array.Reverse(arabalar);
            //Array.Sort(arabalar);
            //Array.Reverse(arabalar);
            //foreach (var araba in arabalar)
            //{
            //    Console.WriteLine(araba);
            //}

            #endregion

            #region Array.list

            //ArrayList dizi = new ArrayList();
            //dizi.Add("Adana");
            //dizi.Add(1);
            //dizi.Add(new DateTime());
            //dizi.Add(true);
            //dizi.Add("Urfa");
            //dizi.Add("Bursa");
            //dizi.Add("Edirne");
            //dizi.Add("İzmir");
            //dizi.Add("Ayse");
            //dizi.Add("Fatma");

            ////eleman ekleme 

            //dizi.Insert(3, "Ali");
            //dizi.Insert(5, "Halil");
            ////verilen elemanı kaldırmak için
            //dizi.Remove("Ali");
            ////sıralamak için
            ////dizi.Sort();

            //dizi.TrimToSize();


            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region GenericList

            //int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            //ArrayList cuval = new ArrayList();
            //cuval.Add("ali");
            //cuval.Add(12);

            //List<string> sehirler = new List<string>();
            //sehirler.Add("Adana");
            //sehirler.Add("Bursa");

            //int elemansayisi;
            //List<int> Sayilar = new List<int>();
            //Console.WriteLine("Kaç eleman");
            //elemansayisi = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //int teksayi = 0, ciftsayi = 0, gecici = 0;
            //for (int i = 0; i < elemansayisi; i++)
            //{
            //    gecici = rnd.Next(1, 50);
            //    if (gecici % 2 == 0)
            //        ciftsayi++;
            //    else
            //        teksayi++;

            //            Sayilar.Add(gecici);
            //        }
            //        Console.WriteLine("Tek sayi Adedi:"+ teksayi);
            //        Console.WriteLine("cift sayi Adedi:" + ciftsayi);

            


            #endregion
        }
    }
}
