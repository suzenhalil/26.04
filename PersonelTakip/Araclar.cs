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
    public partial class Araclar : Form
    {
        List<Arac> Arabalar = new List<Arac>();
        public enum KasaTipi
        {
            Cupe,
            Sedan,
            Cabrio,
            Hatchback,
            StationWagon
        }
        public enum YakitTipi
        {
            Benzin,
            Motorin,
            Elektrik,
            Hybrid

        }
        public enum Vites
        {
            Manuel,
            YariOtomatik,
            Otomatik
        }
        public enum DonanimPaketi
        {
            Full,
            FullArtiFull,
            Bos
        }
        struct Araba
        {
            public string Marka;
            public string Model;
            public string Renk;
            public KasaTipi Kasa;
            public Vites Vites;
            public string GuvenlikPaketi;
            public string Motor;
            public YakitTipi YakitTipi;
            public DonanimPaketi Paket;
            public DateTime CikisYili;
            private int MotorGucu;

            public void SetMotorGucu(int motorgucu)
            {
                MotorGucu = motorgucu;
            }
            public int GetMotorGucu()
            {
                return MotorGucu;
            }


        }

        public class Arac
        {
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Renk { get; set; }
            public KasaTipi Kasa { get; set; }
            public Vites Vites { get; set; }
            public string GuvenlikPaketi { get; set; }
            public string Motor { get; set; }
            public YakitTipi YakitTipi { get; set; }
            public DonanimPaketi DonanimPaketi { get; set; }
            public int MotorGucu { get; set; }

        }
        public Araclar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Araclar_Load(object sender, EventArgs e)
        {
            // Donanim PAketlerini Ekliyoruz
            cmbDonanim.Items.AddRange(Enum.GetNames(typeof(DonanimPaketi)));
            cmbDonanim.SelectedIndex = 0;

            //Kasa Tiplerini ComboBox'a Ekliyoruz
            cmbKasa.Items.AddRange(Enum.GetNames(typeof(KasaTipi)));
            cmbKasa.SelectedIndex = 0;

            // Yakit Tipini Ekliyoruz
            cmbYakit.Items.AddRange(Enum.GetNames(typeof(YakitTipi)));
            cmbYakit.SelectedIndex = 0;

            // Vites Tipini Ekliyoruz
            cmbVites.Items.AddRange(Enum.GetNames(typeof(Vites)));
            cmbVites.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba arac = new Araba();

            arac.SetMotorGucu(500);
            arac.Kasa = (KasaTipi)Enum.Parse(typeof(KasaTipi), cmbKasa.Text);
            arac.YakitTipi = (YakitTipi)Enum.Parse(typeof(YakitTipi), cmbYakit.Text);
            arac.Vites = (Vites)Enum.Parse(typeof(Vites), cmbVites.Text);
            arac.Paket = (DonanimPaketi)Enum.Parse(typeof(DonanimPaketi), cmbDonanim.Text);

            arac.Motor = txtMotor.Text;
            arac.Renk = txtRenk.Text;
            arac.Marka = txtMarka.Text;
            arac.Model = txtModel.Text;

            StreamWriter sw = File.AppendText("Arabalar.text");
            string yazilacaksatir = arac.Marka + ";" + arac.Model + ";" + arac.Renk + ";" 
                + arac.Motor + ";" + arac.Kasa + ";" + arac.Vites + ";" + arac.Paket + ";";
            sw.WriteLine(yazilacaksatir);
            sw.Close();

            Arac bmw = new Arac();
            bmw.Marka = "Bmw";
            bmw.Renk = "Siyah";
            bmw.GuvenlikPaketi = "Full";
            bmw.Kasa = KasaTipi.Hatchback;
            bmw.MotorGucu = 200;
            bmw.Vites = Vites.Otomatik;
            bmw.YakitTipi = YakitTipi.Elektrik;
            Arabalar.Add(bmw);

            Arac Alfa = new Arac();
            Alfa.Marka = "Alfa";
            Alfa.Renk = "Siyah";
            Alfa.GuvenlikPaketi = "Full";
            Alfa.Kasa = KasaTipi.Hatchback;
            Alfa.MotorGucu = 200;
            Alfa.Vites = Vites.Otomatik;
            Alfa.YakitTipi = YakitTipi.Elektrik;
            Arabalar.Add(Alfa);

            dataGridView1.DataSource = Arabalar.ToList();

        }
    }
}
