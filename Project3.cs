using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new
            OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data
            Source=C:\uyeler.xlsx; Extended Properties='Excel 12.0 xml
            ;HDR=YES'");
            baglan.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM[Sayfa1$]", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            baglan.Close();
        }
    }
}
