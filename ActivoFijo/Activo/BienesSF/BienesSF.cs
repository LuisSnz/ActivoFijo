using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Activo.BienesSF
{
    public partial class BienesSF : Form
    {
        public BienesSF()
        {
            InitializeComponent();
        }

        private void BienesSF_Load(object sender, EventArgs e)
        {
            GridBienesSF.Width = Clases.Variables.GridWidth;
            GridBienesSF.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, " +
                "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where nofactura=''";
            Clases.LLenadoGrids.llenarGrid(GridBienesSF, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            NuevoBienesSF Nuevo = new NuevoBienesSF();
            Nuevo.ShowDialog();
            if (Nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienesSF, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            ModificarBienesSF modificar = new ModificarBienesSF();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienesSF, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void DarDeBaja_Click(object sender, EventArgs e)
        {
            BajaBienesSF baja = new BajaBienesSF();
            baja.ShowDialog();
            if (baja.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienesSF, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            BuscarBienesSF buscar = new BuscarBienesSF();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienesSF, Clases.Variables.ConsultaBuscar, "bienes");
            }

        private void Excel_Click(object sender, EventArgs e)
        {
            Clases.Excel.GridViewExcel(GridBienesSF);
        }

        private void Etiqueta_Click(object sender, EventArgs e)
        {
            Clases.Variables.IEtiqueta = GridBienesSF.CurrentRow.Cells[1].Value.ToString();
            Clases.Etiquetas.ImprimirEtiquetas( Clases.Variables.IEtiqueta, Clases.Variables.IEtiqueta);
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            ReporteBienesSF reporte = new ReporteBienesSF();
            reporte.ShowDialog();
        }

        private void CambioPorEmpleado_Click(object sender, EventArgs e)
        {
            CambioBienes.CambioPorEmpleado cambio =new CambioBienes.CambioPorEmpleado();
            cambio.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(GridBienesSF, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void CambioDeBien_Click(object sender, EventArgs e)
        {
            Clases.Variables.IdCambio = Clases.Variables.IdBienesSF;
            Clases.Variables.EtiquetaCambio = Clases.Variables.BienesSFEtiqueta;
            Clases.Variables.OrdenCambio = Clases.Variables.BienesSFOrdenCompra;
            Clases.Variables.ArticuloCambio = Clases.Variables.BienesSFDescripcionArticulo;
            Clases.Variables.ObservacionesCambio = Clases.Variables.BienesSFObservacion;
            Clases.Variables.ResguardoCambio = Clases.Variables.BienesSFEmpleado;
            Clases.Variables.DeptoCambio = Clases.Variables.BienesSFDepartamento;
            CambioBienes.CambioPorBien cambio =new CambioBienes.CambioPorBien();
            cambio.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(GridBienesSF, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void GridBienesSF_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridBienesSF.CurrentRow;
            Clases.Variables.IdBienesSF = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.BienesSFEtiqueta = filaSeleccionada.Cells[1].Value.ToString();
            Clases.Variables.BienesSFOrdenCompra = filaSeleccionada.Cells[2].Value.ToString();
            Clases.Variables.BienesSFTotal = filaSeleccionada.Cells[3].Value.ToString();
            Clases.Variables.BienesSFFamilia = filaSeleccionada.Cells[4].Value.ToString();
            Clases.Variables.BienesSFDescripcionArticulo = filaSeleccionada.Cells[5].Value.ToString();
            Clases.Variables.BienesSFEmpleado = filaSeleccionada.Cells[6].Value.ToString();
            Clases.Variables.BienesSFDepartamento = filaSeleccionada.Cells[7].Value.ToString();
            Clases.Variables.BienesSFConsumible = filaSeleccionada.Cells[8].Value.ToString();
            Clases.Variables.BienesSFObservacion = filaSeleccionada.Cells[10].Value.ToString();
        }

        private void GridBienesSF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarBienesSF modificar = new ModificarBienesSF();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienesSF, Clases.Variables.ConsultaBuscar, "bienes");
        }
    }
}
