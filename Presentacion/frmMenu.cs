using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;

namespace Presentacion
{
    public partial class frmMenu : Form
    {
        frmCita objCita = new frmCita();
        public frmMenu(string usu, string cargo)
        {
            InitializeComponent();
            lblUsuario.Text = usu;
            lblTipoUsu.Text = cargo;
            timerHora.Start();
            
        }
        private void AbrirFormularioEnPanel(object frmhijo)
        {
            if (this.panelPadre.Controls.Count > 0)

                this.panelPadre.Controls.RemoveAt(0);
            Form fh = frmhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPadre.Controls.Add(fh);
            this.panelPadre.Tag = fh;
            fh.Show();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

            AbrirFormularioEnPanel(new frmCita());
            
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            frmCrudCita objCrudCita = new frmCrudCita();
            objCrudCita.FormClosed += new FormClosedEventHandler(of_FormClosed);
            objCrudCita.Show();
        }
        private void of_FormClosed(object sender, FormClosedEventArgs e)
        {
            AbrirFormularioEnPanel(new frmCita());
        }
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin log = new frmLogin();
            log.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmCita());
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            reportes.frmReporteCitas objrep = new reportes.frmReporteCitas();
            objrep.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmCliente());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
