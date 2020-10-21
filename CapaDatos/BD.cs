using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class BD
    {
        
        public void connect() {
            string connstring = "server=localhost;uid=root;pwd=*****;database=maquinarias_gaq";
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            //conn.ConnectionString = connstring;
            //conn.Open();
        }

        public void close() {
            //conn.Close();
        }
    }
}
