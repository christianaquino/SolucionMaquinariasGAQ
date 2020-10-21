using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class BD
    {
        string connstring = "Server=127.0.0.1;Uid=root;Pwd=******;Database=maquinarias_gaq";
        MySqlConnection conn;
        public void connect() {
            conn = new MySqlConnection(connstring);
            //conn.ConnectionString = connstring;
            conn.Open();
        }

        public void close() {
            conn.Close();
        }
    }
}
