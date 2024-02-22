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
    public partial class CategoryModule : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader dr;
        Connection con = new Connection();
        Category category;
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            LoadTheme();
            category = ct;
            cn = new MySqlConnection(con.MyConnection());
            IdOtomatis();
        }
        public void Clear()
        {
            idCat.Clear();
            namCat.Clear();
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
                    command = new MySqlCommand("insert into category(ID,Nama) Values(@ID,@Nama)", cn);
                    command.Parameters.AddWithValue("@ID", idCat.Text);
                    command.Parameters.AddWithValue("@Nama", namCat.Text);
                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Berhasil Ditambahkan");
                    Clear();
                    category.LoadData();
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
            labelProduk.ForeColor = Color.White;
        }
        public void IdOtomatis()
        {
            long hitung;
            string urutan;
            cn.Open();
            command = new MySqlCommand("Select ID FROM category WHERE ID in(SELECT MAX(ID) from category)", cn);
            dr = command.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                hitung = Convert.ToInt64(dr[0].ToString().Substring(dr["ID"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "CAT" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "CAT001";
            }
            dr.Close();
            idCat.Text = urutan;
            cn.Close();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                command = new MySqlCommand("UPDATE category set Nama = @nama WHERE ID LIKE '" + idCat.Text + "'", cn);
                command.Parameters.AddWithValue("@nama", namCat.Text);
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
