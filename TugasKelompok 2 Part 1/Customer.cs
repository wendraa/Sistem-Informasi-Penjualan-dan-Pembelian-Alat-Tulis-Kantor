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
    public partial class Customer : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        Connection con = new Connection();
        MySqlDataReader dr;
        public Customer()
        {
            InitializeComponent();
            LoadTheme();
            cn = new MySqlConnection(con.MyConnection());
            LoadData();
        }
        public void LoadData()
        {
            int i = 0;
            dataCustomer.Rows.Clear();
            cn.Open();
            cmd = new MySqlCommand("Select * From customer", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataCustomer.Rows.Add(i, dr["ID"].ToString(), dr["nama"].ToString(), dr["Nomor"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            CustomerModule customerModule = new CustomerModule(this);
            customerModule.update.Enabled = false;
            customerModule.ShowDialog();
        }
        public void LoadTheme()
        {
            dataCustomer.Font = new Font("Century Gothic", 9f);
        }
        private void dataCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Yakin Hapus Data Ini?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new MySqlCommand("Delete From customer WHERE ID LIKE '" + dataCustomer[1, e.RowIndex].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                CustomerModule customerModul = new CustomerModule(this);
                customerModul.Save.Enabled = false;
                customerModul.idCust.Text = dataCustomer[1, e.RowIndex].Value.ToString();
                customerModul.namCust.Text = dataCustomer[2, e.RowIndex].Value.ToString();
                customerModul.noCust.Text = dataCustomer[3, e.RowIndex].Value.ToString();
                customerModul.ShowDialog();
            }
            LoadData();
        }
    }
}
