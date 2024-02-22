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
    public partial class Pegawai : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        Connection con = new Connection();
        MySqlDataReader dr;
        public Pegawai()
        {
            InitializeComponent();
            LoadTheme();
            cn = new MySqlConnection(con.MyConnection());
            LoadData();
        }
        public void LoadData()
        {
            int i = 0;
            dataPegawai.Rows.Clear();
            cn.Open();
            cmd = new MySqlCommand("Select * From pegawai", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataPegawai.Rows.Add(i, dr["ID"].ToString(), dr["nama"].ToString(), dr["Posisi"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadTheme()
        {
            dataPegawai.Font = new Font("Century Gothic", 9f);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            PegawaiModule pegawaiModule = new PegawaiModule(this);
            pegawaiModule.update.Enabled = false;
            pegawaiModule.Show();
        }
        private void dataPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataPegawai.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if (MessageBox.Show("Yakin Hapus Data Ini?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new MySqlCommand("Delete From pegawai WHERE ID LIKE '" + dataPegawai[1, e.RowIndex].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Data Berhasil Dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(colName == "Edit")
            {
                PegawaiModule pegawaiModul = new PegawaiModule(this);
                pegawaiModul.Save.Enabled = false;
                pegawaiModul.idPeg.Text = dataPegawai[1, e.RowIndex].Value.ToString();
                pegawaiModul.namPeg.Text = dataPegawai[2, e.RowIndex].Value.ToString();
                pegawaiModul.posPeg.Text = dataPegawai[3, e.RowIndex].Value.ToString();
                pegawaiModul.ShowDialog();
            }
            LoadData();
        }
    }
}