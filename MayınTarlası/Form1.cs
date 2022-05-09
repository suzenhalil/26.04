using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> mayinlar = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                int sayi = random.Next(0, 155);
                if (mayinlar.Contains(sayi))
                {
                    i--;
                }
                else
                {
                    mayinlar.Add(sayi);
                }

            }

            for (int i = 0; i < 154; i++)
            {
                PictureBox box = new PictureBox();
                box.Height = 30;
                box.Width = 30;
                box.Name = "box" + i;
                box.BackColor = Color.Bisque;

                if (mayinlar.Contains(i))
                    box.Tag = true;
                else
                    box.Tag = false;
                box.Click += Box_Click;
                flowLayoutPanel1.Controls.Add(box);
            }




        }

        private void Box_Click(object? sender, EventArgs e)
        {
            //sender objesi kimin tarafindan tiklandigi bilgisini tasir.
            PictureBox box = (PictureBox)sender;
            MessageBox.Show(box.Name + " Mayinlimi =" + box.Tag);


        }
    }
}
