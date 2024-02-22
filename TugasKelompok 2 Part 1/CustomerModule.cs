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
    public partial class CustomerModule : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader dr;
        Connection con = new Connection();
        Customer customer;
        public CustomerModule(Customer cr)
        {
            InitializeComponent();
            LoadTheme();
            customer = cr;
            cn = new MySqlConnection(con.MyConnection());
            IdOtomatis();
        }
        public void Clear()
        {
            idCust.Clear();
            namCust.Clear();
            noCust.Clear();
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
                    command = new MySqlCommand("insert into customer(ID,Nama,Nomor) Values(@ID,@Nama,@Nomor)", cn);
                    command.Parameters.AddWithValue("@ID", idCust.Text);
                    command.Parameters.AddWithValue("@Nama", namCust.Text);
                    command.Parameters.AddWithValue("@Nomor", noCust.Text);
                    cn.Open();
                    command.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Berhasil Ditambahkan");
                    Clear();
                    customer.LoadData();
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
            labelCustomer.ForeColor = Color.White;
        }
        public void IdOtomatis()
        {
            long hitung;
            string urutan;
            cn.Open();
            command = new MySqlCommand("Select ID FROM customer WHERE ID in(SELECT MAX(ID) from customer)", cn);
            dr = command.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                hitung = Convert.ToInt64(dr[0].ToString().Substring(dr["ID"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "CST" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "CST001";
            }
            dr.Close();
            idCust.Text = urutan;
            cn.Close();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                command = new MySqlCommand("UPDATE customer set Nama = @nama, Nomor = @nomor where ID LIKE '" + idCust.Text + "'", cn);
                command.Parameters.AddWithValue("@nama", namCust.Text);
                command.Parameters.AddWithValue("@nomor", noCust.Text);
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