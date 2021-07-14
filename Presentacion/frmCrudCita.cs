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
    public partial class frmCrudCita : Form
    {
        clsCita clscit = new clsCita();
        clsNegCita objNegCita = new clsNegCita();
        public frmCrudCita()
        {
            InitializeComponent();
            timerFecha.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNomEmp.Clear();
            txtTipoEmp.Clear();
            txtNomCliente.Clear();
            txtApeCliente.Clear();
            txtnomAnimal.Clear();
            txtTipoAnimal.Clear();
            txtRazaAnimal.Clear();
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            capturarDatos();
        }

        void capturarDatos()
        {
            clscit.nomEmp = txtNomEmp.Text;
            clscit.tipoEmp = txtTipoEmp.Text;
            clscit.nomCli = txtNomCliente.Text;
            clscit.apeCli= txtApeCliente.Text;
            clscit.nomAni = txtnomAnimal.Text;
            clscit.tipoAni = txtTipoAnimal.Text;
            clscit.razaAni = txtRazaAnimal.Text;
            clscit.fecCita = lblFecha.Text;

            objNegCita.guardarCita(clscit);
            MessageBox.Show("Cita agregada ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
