using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;


namespace Presentacion
{
    public partial class frmLogin : Form
    {
        clsUsuario objUsu = new clsUsuario();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarUsu();
            

        }
        public void validarUsu()
        {
            objUsu.usuario = txtUsuario.Text;
            objUsu.contraseña = txtContraseña.Text;
            try
            {
                if (objUsu != null)
                {
                    DataTable dt = new DataTable();
                    clsNegUsuario objNegUsu = new clsNegUsuario();
                    dt = objNegUsu.validarUsuario(objUsu);


                    MessageBox.Show("Bienvenido Usuario : " + dt.Rows[0][2].ToString(), "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                    frmMenu menu = new frmMenu(dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());

                    if (dt.Rows[0][2].ToString() == "Doctor")
                    {
                        menu.btnGenerarReporte.Visible = false;
                    }
                    this.Hide();
                    menu.Show();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
