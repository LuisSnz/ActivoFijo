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


namespace ActivoFijo.Reportes.ValorBienes
{
    public partial class ReporteSaldos : Form
    {
        public ReporteSaldos()
        {
            InitializeComponent();
        }

        private void ReporteSaldos_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = Clases.LLenadoGrids.GenerarDataSet(Clases.Variables.ConsultaBuscar, "bienes").Tables[0];
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            //ReportParameter[] reporte = new ReportParameter[1];
            //reporte[0] = new ReportParameter("total", Clases.Variables.Total);
            //reportViewer1.LocalReport.SetParameters(reporte);
            
            //this.reportViewer1.RefreshReport();
        }
    }
}
