using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class MaquinariasGAQ_Negocio
    {
        public void TryConnection() {
            BD database = new CapaDatos.BD();
            
            database.connect();
            
        }
        
    }
}
