using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ActivoFijo.Catalogos.Vehiculos
{
    public partial class ReporteVehiculos : Form
    {
        public ReporteVehiculos()
        {
            InitializeComponent();
        }

        private void ReporteVehiculos_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = Clases.LLenadoGrids.GenerarDataSet(Clases.Variables.ConsultaBuscar, "vVehiculos").Tables[0];
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
