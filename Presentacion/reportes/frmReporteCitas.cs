using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Presentacion.reportes
{
    public partial class frmReporteCitas : Form
    {
        public frmReporteCitas()
        {
            InitializeComponent();
            mostrarreport();
        }
        void mostrarreport()
        {
            reportes.CRPcitas cremp = new reportes.CRPcitas();
            cry.ReportSource = cremp;
        }
        private void cry_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
