using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace SolucionMaquinariasGAQ
{
    public partial class FormLogin : Form
    {
        MaquinariasGAQ_Negocio negocio = new MaquinariasGAQ_Negocio();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                negocio.Login(textBoxUsuario.Text, textBoxPassword.Text);
                MessageBox.Show("Usuario logueado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
