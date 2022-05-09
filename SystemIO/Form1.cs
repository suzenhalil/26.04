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

namespace SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.DriveInfo[] tumsuruculer = DriveInfo.GetDrives();
            foreach (DriveInfo d in tumsuruculer)
            {
                lstDriver.Items.Add(d.Name);
            }
        }

        private void lstKlasorler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string klasor = lstKlasorler.SelectedItem.ToString();
            string[] klasorler = Directory.GetDirectories(klasor);
            string[] dosyalar = Directory.GetFiles(klasor);
            lstDosyalar.Items.Clear();
            foreach (string d in klasorler)
            {
                lstDosyalar.Items.Add(d);
            }
            foreach (var d in dosyalar)
            {
                lstDosyalar.Items.Add(d);
            }
        }

        private void lstDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            string drive = lstDriver.SelectedItem.ToString();
            string[] directories = Directory.GetDirectories(drive);
            lstKlasorler.Items.Clear();
            foreach (string d in directories)
            {
                lstKlasorler.Items.Add(d);
            }
        }

        private void lstDosyalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
