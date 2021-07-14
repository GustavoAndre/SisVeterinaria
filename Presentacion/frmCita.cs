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
    public partial class frmCita : Form
    {
        clsNegCita objnegCita = new clsNegCita();
        public frmCita()
        {
            InitializeComponent();
            listarCitas();
        }

        public void listarCitas()
        {
            DataTable dt = null;
            dt= objnegCita.listarCita();
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = dt;
        }
        

        private void frmCita_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
