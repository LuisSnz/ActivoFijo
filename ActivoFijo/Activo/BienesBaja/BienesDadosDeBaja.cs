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
    public partial class BienesDadosDeBaja : Form
    {
        public BienesDadosDeBaja()
        {
            InitializeComponent();
        }

        private void BienesDadosDeBaja_Load(object sender, EventArgs e)
        {
            GridBaja.Width = Clases.Variables.GridWidth;
            GridBaja.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden, RTRIM(NoFactura) AS NoFactura, Total, " +
                "RTRIM(Articulo) as Articulo, RTRIM(Observacion) as Observacion, Departamento, RTRIM(Empleado) as Empleado," +
                " FechaCompra, Marca, Serie, Modelo, RTRIM(MotivoBaja) as MotivoBaja, EstatusBaja," +
                "(convert(varchar, FechaBaja,101))  as FechaBaja,RTRIM( ObservacionBaja) as ObservacionBaja," +
                " RTRIM(ValorActual) as ValorActual, Consumible, Borro FROM BajaBienes";
            Clases.LLenadoGrids.llenarGrid(GridBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            ModificarBienesDDBaja modificar = new ModificarBienesDDBaja();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            BuscarBienesDDBaja buscar = new BuscarBienesDDBaja();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Clases.Excel.GridViewExcel(GridBaja);
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            ReporteBienesDDBaja reporte = new ReporteBienesDDBaja();
            reporte.ShowDialog();
        }

        private void GridBaja_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdBienesB = GridBaja.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.BienesBMotivoBaja = GridBaja.CurrentRow.Cells[13].Value.ToString();
            Clases.Variables.BienesBObservacion = GridBaja.CurrentRow.Cells[16].Value.ToString();
            Clases.Variables.BienesBValor = GridBaja.CurrentRow.Cells[17].Value.ToString();
        }

        private void GridBaja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarBienesDDBaja modificar = new ModificarBienesDDBaja();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBaja, Clases.Variables.ConsultaBuscar, "BajaBienes");
        }
    }
}
