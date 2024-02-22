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
    public partial class ProductModule : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader dr;
        Connection con = new Connection();
        Product product;
        public ProductModule(Product pd)
        {
            InitializeComponent();
            LoadTheme();
            product = pd;
            cn = new MySqlConnection(con.MyConnection());
            LoadCategory();
            IdOtomatis();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            idPrdk.Clear();
            namPrdk.Clear();
            comCat.SelectedIndex = 0;
            harPrdk.Clear();
            updPrdk.Value = 1;
            Save.Enabled = true;
            update.Enabled = false;
            IdOtomatis();
        }
        private void LoadCategory()
        {
            comCat.Items.Clear();
            comCat.DataSource = con.GetTable("SELECT * FROM category");
            comCat.DisplayMember = "Nama";
            comCat.ValueMember = "ID";
        }
        private void LoadTheme()
        {
            panelJudul.BackColor = ThemeColor.PrimaryColor;
            labelProduct.ForeColor = Color.White;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Apakah Ingin Disimpan?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new MySqlCommand("insert into barang(ID,Nama,cid,Harga,Jumlah) Values(@ID,@Nama,@cid,@Harga,@Jumlah)", cn);
                    command.Parameters.AddWithValue("@ID", idPrdk.Text);
                    command.Parameters.AddWithValue("@Nama", namPrdk.Text);
                    command.Parameters.AddWithValue("@cid", comCat.SelectedValue);
                    command.Parameters.AddWithValue("@Harga", double.Parse(harPrdk.Text));
                    command.Parameters.AddWithValue("@Jumlah", updPrdk.Value);
                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Berhasil Ditambahkan");
                    Clear();
                    product.LoadData();
                    IdOtomatis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                command = new MySqlCommand("UPDATE product set Nama = @nama, cid = @cid, Harga = @Harga, Jumlah = @Jumlah where ID LIKE '" + idPrdk.Text + "'", cn);
                command.Parameters.AddWithValue("@Nama", namPrdk.Text);
                command.Parameters.AddWithValue("@cid", comCat.SelectedValue);
                command.Parameters.AddWithValue("@Harga", double.Parse(harPrdk.Text));
                command.Parameters.AddWithValue("@Jumlah", updPrdk.Value);
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
        public void IdOtomatis()
        {
            long hitung;
            string urutan;
            cn.Open();
            command = new MySqlCommand("Select ID FROM barang WHERE ID in(SELECT MAX(ID) from barang)", cn);
            dr = command.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                hitung = Convert.ToInt64(dr[0].ToString().Substring(dr["ID"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "PRDK" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "PRDK001";
            }
            dr.Close();
            idPrdk.Text = urutan;
            cn.Close();
        }
    }
}
