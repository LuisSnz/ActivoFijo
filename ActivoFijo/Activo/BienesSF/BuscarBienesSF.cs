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
    public partial class BuscarBienesSF : Form
    {
        public BuscarBienesSF()
        {
            InitializeComponent();
        }

        private void BuscarBienesSF_Load(object sender, EventArgs e)
        {
            Clases.BienesSinFactura.CBEtiqueta(CBBuscar);
        }

        private void Etiqueta_CheckedChanged(object sender, EventArgs e)
        {
            if (Etiqueta.Checked == true)
                Clases.BienesSinFactura.CBEtiqueta(CBBuscar);
        }

        private void Articulo_CheckedChanged(object sender, EventArgs e)
        {
            if (Articulo.Checked == true)
                Clases.BienesSinFactura.CBBuscarArticulo(CBBuscar);
        }

        private void Proveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (Proveedor.Checked == true)
                Clases.BienesSinFactura.CBProveedor(CBBuscar);
        }

        private void Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (Empleado.Checked == true)
                Clases.BienesSinFactura.CBNombre(CBBuscar);
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
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id " +
                    "where bienes.Etiqueta=" + CBBuscar.SelectedItem.ToString() + " and NoFactura=''";
                else if (Articulo.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id " +
                    "where CatArticulos.Descripcion='" + CBBuscar.SelectedItem.ToString() + "' and NoFactura=''";
                else if (Empleado.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id " +
                    "where empleados.Nombre='" + CBBuscar.SelectedItem.ToString() + "' and NoFactura=''";
                else if (Proveedor.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura, " +
                    "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                    "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                    "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                    "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id " +
                    "where RTRIM(Proveedores.Nombre)='" + CBBuscar.SelectedItem.ToString() + "' and NoFactura=''";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un valor a buscar");
            }
        }

        private void Todo_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, " +
                "bienes.Total, Familia.Descripcion, dbo.CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where nofactura=''";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
