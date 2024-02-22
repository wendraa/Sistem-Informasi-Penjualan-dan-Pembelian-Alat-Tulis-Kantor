using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek
{
    public partial class FormPegawai : Form
    {
        Connection con = new Connection();
        MySqlCommand command;
        MySqlDataAdapter da;
        public FormPegawai()
        {
            InitializeComponent();
            con.connect();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }
        private void DataLoad()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Select * From pegawai", con.cn);
                command.ExecuteNonQuery();
                da = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataPegawai.DataSource = dt.DefaultView;
                con.cn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormPegawai_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Save.Enabled = true;
            input.Enabled = true;
        }
        private void DataPegawai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idPeg.Text = DataPegawai.CurrentRow.Cells[0].Value.ToString();
            namPeg.Text = DataPegawai.CurrentRow.Cells[1].Value.ToString();
            posPeg.Text = DataPegawai.CurrentRow.Cells[2].Value.ToString();
            Edit.Enabled = true;
            Hapus.Enabled = true;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            update.Enabled = true;
            input.Enabled = true;
            Hapus.Enabled = true;
            Save.Enabled = false;
        }
        private void cancel()
        {
            Save.Enabled = false;
            Edit.Enabled = false;
            Hapus.Enabled = false;
            update.Enabled = false;
            idPeg.Clear();
            namPeg.Clear();
            posPeg.Clear();
            input.Enabled = false;
        }
        private void Tambah_Click(object sender, EventArgs e)
        {
            if (idPeg.Text == "" || namPeg.Text == "" || posPeg.Text == "")
            {
                MessageBox.Show("Lengkapi Data Terlebih Dahulu !!");
            }
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Insert into pegawai(id,nama,posisi) VALUES('" + idPeg.Text + "','" + namPeg.Text + "','" + posPeg.Text + "')", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Berhasil Ditambahkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cancel();
                DataLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Hapus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Anda Yakin Hapus Data Ini?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.No)
            {
                cancel();
            }
            else
            {
                try
                {
                    con.cn.Close();
                    con.cn.Open();
                    command = new MySqlCommand("DELETE FROM pegawai WHERE id = '" + idPeg.Text + "'", con.cn);
                    command.ExecuteNonQuery();
                    con.cn.Close();
                    MessageBox.Show("Berhasil Dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cancel();
                    DataLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            cancel();
        }
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("Update pegawai set nama = '" + namPeg.Text + "',posisi = '" + posPeg.Text + "' WHERE id = '" + idPeg.Text + "'", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("Berhasil Diperbarui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cancel();
                DataLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}