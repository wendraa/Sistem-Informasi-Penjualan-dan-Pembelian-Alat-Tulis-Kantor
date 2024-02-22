using Kelompok2Tugas.Config;
using Kelompok2Tugas.Custom;
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
    public partial class Product : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        Connection con = new Connection();
        MySqlDataReader dr;
        public Product()
        {
            InitializeComponent();
            LoadTheme();
            cn = new MySqlConnection(con.MyConnection());
            LoadData();
        }
        public void LoadData()
        {
            int i = 0;
            dataProduct.Rows.Clear();
            cn.Open();
            cmd = new MySqlCommand("SELECT p.ID, p.Nama, c.Nama, p.Harga, p.Jumlah FROM barang AS p INNER JOIN category AS c ON c.id = p.cid WHERE CONCAT(p.Nama, c.Nama) LIKE '%" + txtSearch.Text + "%'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void LoadTheme()
        {
            dataProduct.Font = new Font("Century Gothic", 9f);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);
            productModule.update.Enabled = false;
            productModule.ShowDialog();
        }
        private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Yakin Hapus Data Ini?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new MySqlCommand("Delete From barang WHERE ID LIKE '" + dataProduct[1, e.RowIndex].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                ProductModule produkModul = new ProductModule(this);
                produkModul.Save.Enabled = false;
                produkModul.idPrdk.Text = dataProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                produkModul.namPrdk.Text = dataProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                produkModul.comCat.Text = dataProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                produkModul.harPrdk.Text = dataProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                produkModul.updPrdk.Value = int.Parse(dataProduct.Rows[e.RowIndex].Cells[5].Value.ToString());
                produkModul.ShowDialog();
            }
            LoadData();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
