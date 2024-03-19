using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registry.CurrentUser.CreateSubKey("Kadir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registry.CurrentUser.CreateSubKey("Kadir").SetValue("Görevi",
                "Web Developer");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var deger = Registry.CurrentUser.OpenSubKey("Kadir").GetValue("Görevi");
            MessageBox.Show(deger.ToString());

        }
    }
}
