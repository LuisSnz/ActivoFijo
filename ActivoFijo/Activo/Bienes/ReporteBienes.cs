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
    public partial class ReporteBienes : Form
    {
        public ReporteBienes()
        {
            InitializeComponent();
        }

        private void ReporteBienes_Load(object sender, EventArgs e)
        {
            ReportParameter[] reporte = new ReportParameter[11];
            reporte[0] = new ReportParameter("id", Clases.Variables.IdBienes);
            reporte[1] = new ReportParameter("Etiqueta", Clases.Variables.BienesEtiqueta);
            reporte[2] = new ReportParameter("NoOrden", Clases.Variables.BienesOrdenCompra);
            reporte[3] = new ReportParameter("factura", Clases.Variables.BienesFactura);
            reporte[4] = new ReportParameter("Serie", Clases.Variables.BienesSerie);
            reporte[5] = new ReportParameter("departamento", Clases.Variables.BienesDepartamento);
            reporte[6] = new ReportParameter("articulo", Clases.Variables.BienesDescripcionArticulo);
            reporte[7] = new ReportParameter("observaciones", Clases.Variables.BienesObservacion);
            reporte[8] = new ReportParameter("nombre", Clases.Variables.BienesEmpleado);
            reporte[9] = new ReportParameter("total", "$" + Clases.Variables.BienesTotal);
            reporte[10] = new ReportParameter("Familia", Clases.Variables.BienesFamilia);
            reportViewer1.LocalReport.SetParameters(reporte);
            reportViewer1.RefreshReport();
        }
    }
}
