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
    public partial class CariProduct : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader dr;
        Connection con = new Connection();
        Cashier cashier;
        public CariProduct(Cashier cr)
        {
            InitializeComponent();
            cn = new MySqlConnection(con.MyConnection());
            cashier = cr;
            LoadData();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadData()
        {
            int i = 0;
            dataProduct.Rows.Clear();
            cn.Open();
            command = new MySqlCommand("SELECT p.ID, p.Nama, c.Nama, p.Harga, p.Jumlah FROM barang AS p INNER JOIN category AS c ON c.id = p.cid WHERE CONCAT(p.Nama, c.Nama) LIKE '%" + txtSearch.Text + "%'", cn);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataProduct.Columns[e.ColumnIndex].Name;
            if(colName == "Select")
            {
                Qty qty = new Qty(cashier);
                qty.ProductDetail(dataProduct.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dataProduct.Rows[e.RowIndex].Cells[4].Value.ToString()), cashier.lblTransNo.Text, int.Parse(dataProduct.Rows[e.RowIndex].Cells[5].Value.ToString()));
                qty.ShowDialog();
            }
        }
    }
}
