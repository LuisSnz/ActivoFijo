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

namespace ActivoFijo.Activo.Bienes
{
    public partial class ReporteImprimirBienes : Form
    {
        public ReporteImprimirBienes()
        {
            InitializeComponent();
        }

        private void ReporteImprimirBienes_Load(object sender, EventArgs e)
        {
            ReportParameter[] reporte = new ReportParameter[12];
            reporte[0] = new ReportParameter("Etiqueta", Clases.Variables.ImprimirBienesEtiqueta);
            reporte[1] = new ReportParameter("NoOrden", Clases.Variables.ImprimirBienesOrdenCompra);
            reporte[2] = new ReportParameter("factura", Clases.Variables.ImprimirBienesFactura);
            reporte[3] = new ReportParameter("Serie", Clases.Variables.ImprimirBienesSerie);
            reporte[4] = new ReportParameter("departamento", Clases.Variables.ImprimirBienesDepartamento);
            reporte[5] = new ReportParameter("articulo", Clases.Variables.ImprimirBienesDescripcionArticulo);
            reporte[6] = new ReportParameter("observaciones", Clases.Variables.ImprimirBienesObservacion);
            reporte[7] = new ReportParameter("nombre", Clases.Variables.ImprimirBienesEmpleado);
            reporte[8] = new ReportParameter("total", "$" + Clases.Variables.ImprimirBienesTotal);
            reporte[9] = new ReportParameter("Familia", Clases.Variables.ImprimirBienesFamilia);
            reporte[10] = new ReportParameter("cantidad", Clases.Variables.ImprimirBienesCantidad);
            reporte[11] = new ReportParameter("etiquetafinal","a "+ Clases.Variables.ImprimirBienesEtiquetaFinal);
            reportViewer1.LocalReport.SetParameters(reporte);
            reportViewer1.RefreshReport();
        }
    }
}
