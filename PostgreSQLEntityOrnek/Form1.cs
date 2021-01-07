using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreSQLEntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Context c = new Context();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = c.Birims.ToList();
            dataGridView1.DataSource = degerler;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Birim b = new Birim();
            b.birimad = textBox1.Text;
            c.Birims.Add(b);
            c.SaveChanges();
            MessageBox.Show("Birim eklendi");
        }
    }
}
