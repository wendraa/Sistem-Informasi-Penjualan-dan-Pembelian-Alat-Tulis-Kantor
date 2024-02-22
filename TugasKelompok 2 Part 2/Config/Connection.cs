using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelompok2Tugas.Config
{
   class Connection
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        private string con;
        public string MyConnection()
        {
            con = "Datasource = 127.0.0.1; username = root; password=; database=tokoalattulis";
            return con;
        }
        public DataTable GetTable(string query)
        {
            cn.ConnectionString = MyConnection();
            cm = new MySqlCommand(query, cn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
