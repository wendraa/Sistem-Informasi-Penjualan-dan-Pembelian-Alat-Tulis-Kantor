using Kelompok2Tugas.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelompok2Tugas
{
    public partial class Qty : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        Connection con = new Connection();
        MySqlDataReader dr;
        Cashier cashier;
        private string ID;
        private double Harga;
        private String noTrans;
        private int Jumlah;
        public Qty(Cashier cr)
        {
            InitializeComponent();
            cn = new MySqlConnection(con.MyConnection());
            cashier = cr;
        }
        public void ProductDetail(string ID, double Harga, string noTrans, int Jumlah)
        {
            this.ID = ID;
            this.Harga = Harga;
            this.noTrans = noTrans;
            this.Jumlah = Jumlah;
        }
        private void Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (txtJumlah.Text != string.Empty))
            {
                cn.Open();
                command = new MySqlCommand("INSERT INTO penjualan(noTrans, ID, Harga, Jumlah, Tanggal)VALUES(@noTrans, @ID, @Harga, @Jumlah, @Tanggal)", cn);
                command.Parameters.AddWithValue("@noTrans", noTrans);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Harga", Harga);
                command.Parameters.AddWithValue("@Jumlah", int.Parse(txtJumlah.Text));
                command.Parameters.AddWithValue("@Tanggal", DateTime.Now);
                command.ExecuteNonQuery();
                cn.Close();
                this.Dispose();
                cashier.LoadPenjualan();
                
            }
        }
    }
}
