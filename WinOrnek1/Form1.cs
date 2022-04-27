using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> araclar = new List<string>();
            araclar.Add("Tofas");
            araclar.Add("Bmw");
            araclar.Add("Mercedes");
            araclar.Add("Subaru");

            foreach (var araba in araclar)
            {
                listBox1.Items.Add(araba);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int kap = 0;
            for (int i = 0; i < 50; i++)
            {
                kap = rast.Next(50);
                if (kap%2 == 0)
                {
                    listBox1.Items.Add(kap);
                }
                if (kap % 2 != 0)
                {
                    listBox2.Items.Add(kap);
                }
                if (kap % 15 == 0)
                {
                    listBox3.Items.Add(kap);
                }
            }
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            int elemansayisi = Convert.ToInt32(deger);
            Random rnd = new Random();
            int[] sayilar = new int[elemansayisi];
            int bir=0, iki=0, uc=0, dort=0, bes=0, alti=0, yedi=0, sekiz=0, dokuz=0;
            for (int i = 0; i < elemansayisi; i++)
            {
                sayilar[i]= rnd.Next(10);
                if (sayilar[i] == 0)
                    bir = bir + 1;
                else if (sayilar[i] == 1)
                    iki = iki + 1;
                else if (sayilar[i] == 2)
                    uc = uc + 1;
                else if (sayilar[i] == 3)
                    dort = dort + 1;
                else if (sayilar[i] == 4)
                    bes = bes + 1;
                else if (sayilar[i] == 5)
                    alti = alti + 1;
                else if (sayilar[i] == 6)
                    yedi = yedi + 1;
                else if (sayilar[i] == 7)
                    sekiz = sekiz + 1;
                else if (sayilar[i] == 8)
                    dokuz = dokuz + 1;
                


                    
            }

            List<string> ihtimal = new List<string>();
            ihtimal.Add("1 Frekansı: " + bir);
            ihtimal.Add("2 Frekansı: " + iki);
            ihtimal.Add("3 Frekansı: " + uc);
            ihtimal.Add("4 Frekansı: " + dort);
            ihtimal.Add("5 Frekansı: " + bes);
            ihtimal.Add("6 Frekansı: " + alti);
            ihtimal.Add("7 Frekansı: " + yedi);
            ihtimal.Add("8 Frekansı: " + sekiz);
            ihtimal.Add("9 Frekansı: " + dokuz);

            foreach (var aaa in ihtimal)
            {
                listBox2.Items.Add(aaa);
            }

            //Girilen eleman sayısı kadar 1-10 arasında sayı üretsin.
            //oluşan dizideki sayıların tekrar sayısı (frekans)
            //sonucları listbox a yaz

            // 1- random deger at
            // 2- Freak
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random kelp = new Random();
            int[] sira = new int[20];
            for (int i = 0; i < sira.Length; i++)
            {
                sira[i] = kelp.Next(100);
                listBox1.Items.Add(sira[i]);
            }
            int enkucuk = sira[0], enbuyuk = sira[0];
            for (int i = 1; i < sira.Length; i++)
            {
                if (enkucuk > sira[i])
                {
                    enkucuk = sira[i];
                }
                if (enbuyuk < sira[i])
                {
                    enbuyuk = sira[i];
                }
            }
            listBox3.Items.Add ("En Küçük Sayı: " + enkucuk);
            listBox3.Items.Add("En Büyük Sayı: " + enbuyuk);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
