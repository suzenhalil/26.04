using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class PersonelKayit : Form
    {
        string ad, soyad, tcno, gsm, email;
        DateTime dogumtarihi;
        List<string> Adlar            = new List<string>();
        List<string> Soyadlar         = new List<string>();
        List<string> TcNolar          = new List<string>();
        List<string> Gsmler           = new List<string>();
        List<string> Emailler         = new List<string>();
        List<DateTime> DogumTarihleri = new List<DateTime>();

        public PersonelKayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines("Personel.text");
            foreach (var satir in satirlar)
            {
                string[] veriler = satir.Split(";");
                Adlar.Add(veriler[0]);
                Soyadlar.Add(veriler[1]);
                Gsmler.Add(veriler[2]);
                Emailler.Add(veriler[3]);
                TcNolar.Add(veriler[4]);
                DogumTarihleri.Add(Convert.ToDateTime(veriler[5]));
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Deger okuma
            ad = txtad.Text;
            soyad = txtsoyad.Text;
            tcno = txttcno.Text;
            gsm = txtgsm.Text;
            email = txtemail.Text;

            dogumtarihi = dateTimePicker1.Value;
            #endregion

            #region Kontrol

            if (ad.Length < 2)
            {
                MessageBox.Show("Ad alani en az iki karakter olmalidir..");
                return;
            }
            if (soyad.Length < 2)
            {
                MessageBox.Show("Soyad  alani en az iki karakter olmalidir..");
                return;
            }
            if (gsm.Length < 10)
            {
                //532 111 22 33
                MessageBox.Show("Gsm alani en az 10 karakter olmalidir..");
                return;
            }
            if (!(tcno.Length == 11))
            {
                MessageBox.Show("TcNo alani 11 karakter olmalidir..");
                return;
            }
            if (dogumtarihi.Year > 2005)
            {
                MessageBox.Show("Yaşin tutmadi .Buyude gel..");
                return;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email Duzgun formatta olmalidir..");
                return;
            }
            #endregion

            #region Yazma

            string path = @"Personel.text";
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(ad + ";" + soyad + ";" + tcno + ";" + gsm + ";" + email+ ";"+ dogumtarihi);
            sw.Close();

            #endregion
            FormuTemizle();

        }

        public void FormuTemizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txttcno.Text = "";
            txtgsm.Text = "";
            txtemail.Text = "";

            dateTimePicker1.Value = DateTime.Now;

        }

    }
}
