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

namespace ActivoFijo.Activo.BienesSF
{
    public partial class ReporteBienesSF : Form
    {
        public ReporteBienesSF()
        {
            InitializeComponent();
        }

        private void ReporteBienesSF_Load(object sender, EventArgs e)
        {
            ReportParameter[] reporte = new ReportParameter[10];
            reporte[0] = new ReportParameter("id", Clases.Variables.IdBienesSF);
            reporte[1] = new ReportParameter("Etiqueta", Clases.Variables.BienesSFEtiqueta);
            reporte[2] = new ReportParameter("NoOrden", Clases.Variables.BienesSFOrdenCompra);
            reporte[3] = new ReportParameter("Serie", Clases.Variables.BienesSFSerie);
            reporte[4] = new ReportParameter("departamento", Clases.Variables.BienesSFDepartamento);
            reporte[5] = new ReportParameter("articulo", Clases.Variables.BienesSFDescripcionArticulo);
            reporte[6] = new ReportParameter("observaciones", Clases.Variables.BienesSFObservacion);
            reporte[7] = new ReportParameter("nombre", Clases.Variables.BienesSFEmpleado);
            reporte[8] = new ReportParameter("total", "$" + Clases.Variables.BienesSFTotal);
            reporte[9] = new ReportParameter("Familia", Clases.Variables.BienesSFFamilia);
            reportViewer1.LocalReport.SetParameters(reporte);
            reportViewer1.RefreshReport();
        }
    }
}
