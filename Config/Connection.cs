using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projek
{
    class Connection
    {
        public MySqlConnection cn;
        public void connect()
        {
            cn = new MySqlConnection("Datasource = 127.0.0.1; username = root; password=; database=tokoalattulis");
        }
    }
}
