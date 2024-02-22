using projek.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek
{
    public partial class Beranda : Form
    {
        public Beranda()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pegawai_Click(object sender, EventArgs e)
        {
            FormPegawai pegawai = new FormPegawai();
            pegawai.Show();
            this.Hide();
        }

        private void Costumer_Click(object sender, EventArgs e)
        {
            FormCostumer costumer = new FormCostumer();
            costumer.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormSupplier supplier = new FormSupplier();
            supplier.Show();
            this.Hide();
        }
    }
}
