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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtKullanici.Text =="admin" && txtSifre.Text =="sifre")
            {
                PersonelKayit personelFrm = new PersonelKayit();
                //personelFrm.Owner = this;
                personelFrm.ShowDialog();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış");
            }
        }
    }
}
