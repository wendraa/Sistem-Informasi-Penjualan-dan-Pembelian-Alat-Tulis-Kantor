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
    public partial class PegawaiModule : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        Connection con = new Connection();
        Pegawai pegawai;
        public PegawaiModule(Pegawai pg)
        {
            InitializeComponent();
            LoadTheme();
            pegawai = pg;
            cn = new MySqlConnection(con.MyConnection());
        }
        public void Clear()
        {
            idPeg.Clear();
            namPeg.Clear();
            posPeg.Clear();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Apakah Ingin Disimpan?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    command = new MySqlCommand("insert into pegawai(ID,Nama,Posisi) Values(@ID,@Nama,@Posisi)", cn);
                    command.Parameters.AddWithValue("@ID", idPeg.Text);
                    command.Parameters.AddWithValue("@Nama", namPeg.Text);
                    command.Parameters.AddWithValue("@Posisi", posPeg.Text);
                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Berhasil Ditambahkan");
                    Clear();
                    pegawai.LoadData();
                }
            }catch(Exception ex)
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
            panelPegawaiModul.BackColor = ThemeColor.PrimaryColor;
            labelPegawai.ForeColor = Color.White;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            cn.Open();
            command = new MySqlCommand("UPDATE pegawai set Nama = @nama, Posisi = @posisi where ID LIKE '" + idPeg.Text + "'", cn);
            command.Parameters.AddWithValue("@nama", namPeg.Text);
            command.Parameters.AddWithValue("@posisi", posPeg.Text);
            command.ExecuteNonQuery();
            cn.Close();
            Clear();
            this.Dispose();
            pegawai.LoadData();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void posPeg_TextChanged(object sender, EventArgs e)
        {

        }

        private void namPeg_TextChanged(object sender, EventArgs e)
        {

        }

        private void idPeg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
