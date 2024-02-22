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
    public partial class SupplierModule : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader rd;
        Connection con = new Connection();
        Supplier supplier;
        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            LoadTheme();
            supplier = sp;
            cn = new MySqlConnection(con.MyConnection());
            IdOtomatis();
        }
        public void Clear()
        {
            idSup.Clear();
            namSup.Clear();
            alaSup.Clear();
            noSup.Clear();
            Save.Enabled = true;
            update.Enabled = false;
            IdOtomatis();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Apakah Ingin Disimpan?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new MySqlCommand("insert into supplier(ID,Nama,Alamat,Nomor) Values(@ID,@Nama,@Alamat,@Nomor)", cn);
                    command.Parameters.AddWithValue("@ID", idSup.Text);
                    command.Parameters.AddWithValue("@Nama", namSup.Text);
                    command.Parameters.AddWithValue("@Alamat", alaSup.Text);
                    command.Parameters.AddWithValue("@Nomor", noSup.Text);
                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Berhasil Ditambahkan");
                    Clear();
                    supplier.LoadData();
                    IdOtomatis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void LoadTheme()
        {
            panelJudul.BackColor = ThemeColor.PrimaryColor;
            labelPegawai.ForeColor = Color.White;
        }
        public void IdOtomatis()
        {
            long hitung;
            string urutan;
            cn.Open();
            command = new MySqlCommand("Select ID FROM supplier WHERE ID in(SELECT MAX(ID) from supplier)", cn);
            rd = command.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["ID"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "SP" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "SP001";
            }
            rd.Close();
            idSup.Text = urutan;
            cn.Close();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                command = new MySqlCommand("UPDATE pegawai set Nama = @nama, Posisi = @posisi where ID LIKE '" + idSup.Text + "'", cn);
                command.Parameters.AddWithValue("@nama", namSup.Text);
                command.Parameters.AddWithValue("@posisi", alaSup.Text);
                command.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Berhasil Diperbarui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}