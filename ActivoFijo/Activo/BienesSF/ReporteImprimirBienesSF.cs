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
    public partial class ImprimirBienesSF : Form
    {
        public ImprimirBienesSF()
        {
            InitializeComponent();
        }

        private void ReporteImprimirBienesSF_Load(object sender, EventArgs e)
        {
            ReportParameter[] reporte = new ReportParameter[10];
            reporte[0] = new ReportParameter("Etiqueta", Clases.Variables.ImprimirBienesEtiquetaSF);
            reporte[1] = new ReportParameter("NoOrden", Clases.Variables.ImprimirBienesOrdenCompraSF);
            reporte[2] = new ReportParameter("Serie", Clases.Variables.ImprimirBienesSerieSF);
            reporte[3] = new ReportParameter("departamento", Clases.Variables.ImprimirBienesDepartamentoSF);
            reporte[4] = new ReportParameter("articulo", Clases.Variables.ImprimirBienesDescripcionArticuloSF);
            reporte[5] = new ReportParameter("observaciones", Clases.Variables.ImprimirBienesObservacionSF);
            reporte[6] = new ReportParameter("nombre", Clases.Variables.ImprimirBienesEmpleadoSF);
            reporte[7] = new ReportParameter("total", "$" + Clases.Variables.ImprimirBienesTotalSF);
            reporte[8] = new ReportParameter("Familia", Clases.Variables.ImprimirBienesFamiliaSF);
            reporte[9] = new ReportParameter("cantidad", Clases.Variables.ImprimirBienesCantidadSF);
            reportViewer1.LocalReport.SetParameters(reporte);
            reportViewer1.RefreshReport();
        }
    }
}
