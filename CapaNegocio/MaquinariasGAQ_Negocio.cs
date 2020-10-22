using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class MaquinariasGAQ_Negocio
    {
        public void Login(String user, String password) {
            BD database = new CapaDatos.BD();
            
            database.Login(user, password);
            
        }
        
    }
}
