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
    public partial class Supplier : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        Connection con = new Connection();
        MySqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            LoadTheme();
            cn = new MySqlConnection(con.MyConnection());
            LoadData();
        }
        public void LoadData()
        {
            int i = 0;
            dataSupplier.Rows.Clear();
            cn.Open();
            cmd = new MySqlCommand("Select * From supplier", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataSupplier.Rows.Add(i, dr["ID"].ToString(), dr["Nama"].ToString(), dr["Alamat"].ToString(), dr["Nomor"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            SupplierModule supplierModule = new SupplierModule(this);
            supplierModule.update.Enabled = false;
            supplierModule.Show();
        }
        public void LoadTheme()
        {
            dataSupplier.Font = new Font("Century Gothic", 9f);
        }
        private void dataSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataSupplier.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Yakin Hapus Data Ini?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new MySqlCommand("Delete From supplier WHERE ID LIKE '" + dataSupplier[1, e.RowIndex].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                SupplierModule supplierModul = new SupplierModule(this);
                supplierModul.Save.Enabled = false;
                supplierModul.idSup.Text = dataSupplier[1, e.RowIndex].Value.ToString();
                supplierModul.namSup.Text = dataSupplier[2, e.RowIndex].Value.ToString();
                supplierModul.alaSup.Text = dataSupplier[3, e.RowIndex].Value.ToString();
                supplierModul.noSup.Text = dataSupplier[4, e.RowIndex].Value.ToString();
                supplierModul.ShowDialog();
            }
            LoadData();
        }
    }
}
