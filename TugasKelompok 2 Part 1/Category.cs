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
    public partial class Category : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        Connection con = new Connection();
        MySqlDataReader dr;
        public Category()
        {
            InitializeComponent();
            LoadTheme();
            cn = new MySqlConnection(con.MyConnection());
            LoadData();
        }
        public void LoadData()
        {
            int i = 0;
            dataCategory.Rows.Clear();
            cn.Open();
            cmd = new MySqlCommand("Select * From category", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataCategory.Rows.Add(i, dr["ID"].ToString(), dr["Nama"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadTheme()
        {
            dataCategory.Font = new Font("Century Gothic", 9f);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            CategoryModule categoryModule = new CategoryModule(this);
            categoryModule.update.Enabled = false;
            categoryModule.Show();
        }
        private void dataCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Yakin Hapus Data Ini?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new MySqlCommand("Delete From category WHERE ID LIKE '" + dataCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                CategoryModule categoryModule = new CategoryModule(this);
                categoryModule.Save.Enabled = false;
                categoryModule.idCat.Text = dataCategory[1, e.RowIndex].Value.ToString();
                categoryModule.namCat.Text = dataCategory[2, e.RowIndex].Value.ToString();
                categoryModule.ShowDialog();
            }
            LoadData();
        }
    }
}
