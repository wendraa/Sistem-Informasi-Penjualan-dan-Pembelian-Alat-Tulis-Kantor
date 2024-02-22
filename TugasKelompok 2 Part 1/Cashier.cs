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
    public partial class Cashier : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader dr;
        Connection con = new Connection();
        public Cashier()
        {
            InitializeComponent();
            cn = new MySqlConnection(con.MyConnection());
            timerWaktu.Start();
        }
        #region button
        private void newTrans_Click(object sender, EventArgs e)
        {
            GetTransNo();

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion button
        public void LoadPenjualan()
        {
            int i = 0;
            double Total = 0;
            double Discount = 0;
            dataCashier.Rows.Clear();
            cn.Open();
            command = new MySqlCommand("SELECT c.idjual, p.ID, p.Nama, c.Harga, c.Jumlah, c.Discount, c.Total FROM penjualan AS c INNER JOIN barang AS p ON p.ID = c.ID WHERE c.noTrans LIKE @noTrans and c.Status LIKE 'Pending'", cn);
            command.Parameters.AddWithValue("@noTrans", lblTransNo.Text);
            dr = command.ExecuteReader();
            while(dr.Read())
            {
                i++;
                Total += Convert.ToDouble(dr["Total"].ToString());
                Discount += Convert.ToDouble(dr["Discount"].ToString());
                dataCashier.Rows.Add(i, dr["idjual"].ToString(), dr["ID"].ToString(), dr["Nama"].ToString(), dr["Harga"].ToString(), dr["Jumlah"].ToString(), dr["Discount"].ToString(), double.Parse(dr["Total"].ToString()).ToString("#,##0.00"));
            }
            dr.Close();
            cn.Close();
            labelTotal.Text = Total.ToString("#,##0.00");
            labelDisc.Text = Discount.ToString("#,##0.00");
            GetPenjualanTotal();
        }
        public void GetPenjualanTotal()
        {
            double discount = double.Parse(labelDisc.Text);
            double sales = double.Parse(labelTotal.Text);
            double Vat = sales * 0.12;
            double Vatable = sales - Vat;

            lblVat.Text = Vat.ToString("#,##0.00");
            lblVatable.Text = Vatable.ToString("#,##0.00");
            labelTotal.Text = sales.ToString("#,##0.00");
        }
        public void GetTransNo()
        {
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            string transNo = sdate + "1001";
            lblTransNo.Text = transNo;
        }
        private void timerWaktu_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:MM:ss");
        }

        private void cariPrdk_Click(object sender, EventArgs e)
        {
            CariProduct cariProduct = new CariProduct(this);
            cariProduct.LoadData();
            cariProduct.ShowDialog();
        }

        private void dataCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}