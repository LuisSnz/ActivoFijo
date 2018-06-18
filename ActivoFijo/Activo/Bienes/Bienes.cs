using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Activo.Bienes
{
    public partial class Bienes : Form
    {
        public Bienes()
        {
            InitializeComponent();
        }

        private void Bienes_Load(object sender, EventArgs e)
        {
            GridBienes.Height = Clases.Variables.GridHeight;
            GridBienes.Width = Clases.Variables.GridWidth;
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura,bienes.serie as Serie, " +
                "bienes.Total, Familia.Descripcion, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''";
            Clases.LLenadoGrids.llenarGrid(GridBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            NuevoBienes Nuevo = new  NuevoBienes();
            Nuevo.ShowDialog();
            if (Nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            ModificarBienes modificar = new ModificarBienes();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            BajaBienes baja = new BajaBienes();
            baja.ShowDialog();
            if (baja.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            BuscarBienes buscar = new BuscarBienes();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Clases.Excel.GridViewExcel(GridBienes);
        }

        private void Etiqueta_Click(object sender, EventArgs e)
        {
            Clases.Variables.IEtiqueta = GridBienes.CurrentRow.Cells[1].Value.ToString();
            Clases.Etiquetas.Impresora();
            if (Clases.Variables.ConfImpresora == null)
                MessageBox.Show("Impresora no asignada, porfavor dirijase a (Configuracion/Impresora de etiqueta) y especifique el nombre de la impresora");
            else
                Clases.Etiquetas.ImprimirEtiquetas(Clases.Variables.IEtiqueta, Clases.Variables.IEtiqueta);
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Clases.Variables.BienesCantidad = "1";
            ReporteBienes reporteBienes = new ReporteBienes();
            reporteBienes.ShowDialog();
        }

        private void CambioEmpleado_Click(object sender, EventArgs e)
        {
            CambioBienes.CambioPorEmpleado cambio = new CambioBienes.CambioPorEmpleado();
            cambio.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(GridBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void CambioBien_Click(object sender, EventArgs e)
        {
            Clases.Variables.IdCambio = Clases.Variables.IdBienes;
            Clases.Variables.EtiquetaCambio = Clases.Variables.BienesEtiqueta;
            Clases.Variables.OrdenCambio = Clases.Variables.BienesOrdenCompra;
            Clases.Variables.ArticuloCambio = Clases.Variables.BienesDescripcionArticulo;
            Clases.Variables.ObservacionesCambio = Clases.Variables.BienesObservacion;
            Clases.Variables.ResguardoCambio = Clases.Variables.BienesEmpleado;
            Clases.Variables.DeptoCambio = Clases.Variables.BienesDepartamento;
            CambioBienes.CambioPorBien cambio = new CambioBienes.CambioPorBien();
            cambio.ShowDialog();
            Clases.LLenadoGrids.llenarGrid(GridBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void GridBienes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdBienes = GridBienes.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.BienesEtiqueta = GridBienes.CurrentRow.Cells[1].Value.ToString();
            Clases.Variables.BienesOrdenCompra = GridBienes.CurrentRow.Cells[2].Value.ToString();
            Clases.Variables.BienesFactura = GridBienes.CurrentRow.Cells[3].Value.ToString();
            Clases.Variables.BienesSerie = GridBienes.CurrentRow.Cells[4].Value.ToString();
            Clases.Variables.BienesTotal = GridBienes.CurrentRow.Cells[5].Value.ToString();
            Clases.Variables.BienesFamilia = GridBienes.CurrentRow.Cells[6].Value.ToString();
            Clases.Variables.BienesDescripcionArticulo = GridBienes.CurrentRow.Cells[7].Value.ToString();
            Clases.Variables.BienesEmpleado = GridBienes.CurrentRow.Cells[8].Value.ToString();
            Clases.Variables.BienesDepartamento = GridBienes.CurrentRow.Cells[9].Value.ToString();
            Clases.Variables.BienesConsumible = GridBienes.CurrentRow.Cells[10].Value.ToString();
            Clases.Variables.BienesObservacion = GridBienes.CurrentRow.Cells[12].Value.ToString();
        }

        private void GridBienes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarBienes modificar = new ModificarBienes();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridBienes, Clases.Variables.ConsultaBuscar, "bienes");
        }

        private void ImprimirPorRango_Click(object sender, EventArgs e)
        {
            Activo.Bienes.ImprimirPorRango imprimirPorRango = new ImprimirPorRango();
            imprimirPorRango.ShowDialog();
        }
    }
}
