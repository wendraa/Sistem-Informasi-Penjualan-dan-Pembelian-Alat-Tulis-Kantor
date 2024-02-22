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
        MySqlDataReader rd;
        Connection con = new Connection();
        Pegawai pegawai;
        public PegawaiModule(Pegawai pg)
        {
            InitializeComponent();
            LoadTheme();
            pegawai = pg;
            cn = new MySqlConnection(con.MyConnection());
            IdOtomatis();
        }
        public void Clear()
        {
            idPeg.Clear();
            namPeg.Clear();
            posPeg.Clear();
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
            command = new MySqlCommand("Select ID FROM pegawai WHERE ID in(SELECT MAX(ID) from pegawai)", cn);
            rd = command.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["ID"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "PG" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "PG001";
            }
            rd.Close();
            idPeg.Text = urutan;
            cn.Close();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                command = new MySqlCommand("UPDATE pegawai set Nama = @nama, Posisi = @posisi where ID LIKE '" + idPeg.Text + "'", cn);
                command.Parameters.AddWithValue("@nama", namPeg.Text);
                command.Parameters.AddWithValue("@posisi", posPeg.Text);
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
