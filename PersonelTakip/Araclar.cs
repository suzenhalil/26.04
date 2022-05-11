using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class Araclar : Form
    {
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
            public YakitTipi Yakit;
            public DonanimPaketi Paket;

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

            arac.Kasa = KasaTipi.Sedan;
            arac.Yakit = YakitTipi.Benzin;
        }
    }
}
