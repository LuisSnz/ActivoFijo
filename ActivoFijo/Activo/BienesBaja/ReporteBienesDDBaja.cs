using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Activo.BienesBaja
{
    public partial class ReporteBienesDDBaja : Form
    {
        public ReporteBienesDDBaja()
        {
            InitializeComponent();
        }

        private void ReporteBienesDDBaja_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
