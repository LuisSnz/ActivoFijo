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
    public partial class BuscarBienes : Form
    {
        public BuscarBienes()
        {
            InitializeComponent();
        }

        private void BuscarBienes_Load(object sender, EventArgs e)
        {
            Clases.Bienes.CBEtiqueta(CBBuscar);
        }

        private void Etiqueta_CheckedChanged(object sender, EventArgs e)
        {
            if (Etiqueta.Checked == true)
                Clases.Bienes.CBEtiqueta(CBBuscar);
        }

        private void Articulo_CheckedChanged(object sender, EventArgs e)
        {
            if (Articulo.Checked == true)
                Clases.Articulos.CBBuscarArticulo(CBBuscar);
        }

        private void Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (Empleado.Checked == true)
                Clases.Empleados.CBNombre(CBBuscar);
        }

        private void Proveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (Proveedor.Checked == true)
                Clases.Bienes.CBProveedor(CBBuscar);
        }

        private void Factura_CheckedChanged(object sender, EventArgs e)
        {
            if (Factura.Checked == true)
                Clases.Bienes.CBFactura(CBBuscar);
        }

        private void Departamento_CheckedChanged(object sender, EventArgs e)
        {
            if (Departamento.Checked == true)
                Clases.Bienes.CBDeptos(CBBuscar);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (CBBuscar.SelectedIndex >= 0)
            {
                if (Etiqueta.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>'' " +
                    "and bienes.Etiqueta=" + CBBuscar.SelectedItem.ToString();
                else if (Articulo.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                    "and CatArticulos.Descripcion='" + CBBuscar.SelectedItem.ToString() + "'";
                else if (Empleado.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                    "and empleados.Nombre='" + CBBuscar.SelectedItem.ToString() + "'";
                else if (Departamento.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                    "and empleados.Departamento='" + CBBuscar.SelectedItem.ToString() + "'";
                else if (Factura.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                    "and bienes.NoFactura='" + CBBuscar.SelectedItem.ToString() + "'";
                else if (Proveedor.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                    "and RTRIM(Proveedores.Nombre)='" + CBBuscar.SelectedItem.ToString() + "'";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un valor valido a buscar");
            }
        }

        private void Todo_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
