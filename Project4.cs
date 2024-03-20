using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();

            dosya.Title = "Dosya Seçim penceresi";
            dosya.Filter = "(*.jpg) |*.jpg |(*.png)| *.png| Tüm Dosyalar|*.*";
            if (dosya.ShowDialog( )==DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(dosya.OpenFile());
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
