using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ActivoFijo.Reportes
{
    public partial class ResguardoPorEmleado : Form
    {
        public ResguardoPorEmleado()
        {
            InitializeComponent();
        }

        private void ResguardoPorEmleado_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = Clases.LLenadoGrids.GenerarDataSet(Clases.Variables.ConsultaBuscar, "Bienes").Tables[0];
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
