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
            
        }

        private void Etiqueta_CheckedChanged(object sender, EventArgs e)
        {
            if (Etiqueta.Checked == true)
            {
                CBBuscar.Items.Clear();
                CBBuscar.Text = "";
            }
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
            if (Etiqueta.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura,bienes.serie as Serie, " +
                "bienes.Total, Familia.Descripcion, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>'' " +
                "and bienes.Etiqueta = '" + CBBuscar.Text+"'";
            else if (Articulo.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura,bienes.serie as Serie, " +
                "bienes.Total, Familia.Descripcion, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                "and CatArticulos.Descripcion LIKE '%" + CBBuscar.Text + "%'";
            else if (Empleado.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura,bienes.serie as Serie, " +
                "bienes.Total, Familia.Descripcion, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                "and empleados.Nombre LIKE '%" + CBBuscar.Text + "%'";
            else if (Departamento.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura,bienes.serie as Serie, " +
                "bienes.Total, Familia.Descripcion, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                "and empleados.Departamento LIKE '%" + CBBuscar.Text + "%'";
            else if (Factura.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura,bienes.serie as Serie, " +
                "bienes.Total, Familia.Descripcion, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                "and bienes.NoFactura='" + CBBuscar.Text + "'";
            else if (Proveedor.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura,bienes.serie as Serie, " +
                "bienes.Total, Familia.Descripcion, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                "empleados.Departamento, bienes.Consumible, RTRIM(Proveedores.Nombre) AS Proveedor,bienes." +
                "Observacion AS Observacion FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id where NoFactura <>''" +
                "and RTRIM(Proveedores.Nombre) LIKE '%" + CBBuscar.Text + "%'";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Todo_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Id, bienes.Etiqueta, bienes.NoOrden, bienes.NoFactura,bienes.serie as Serie, " +
                "bienes.Total, Familia.Descripcion, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
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
