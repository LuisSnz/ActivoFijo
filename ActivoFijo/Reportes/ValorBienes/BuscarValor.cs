using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Reportes.ValorBienes
{
    public partial class BuscarValor : Form
    {
        public string factura = " bienes.NoFactura<>''";
        public BuscarValor()
        {
            InitializeComponent();
        }

        private void BuscarValor_Load(object sender, EventArgs e)
        {
            Clases.Empleados.CBNombre(CBBuscar);
            Clases.Variables.CheckSeleccionado = "0";
            Clases.Variables.FamiliaSeleccionada = "0";
        }

        private void Articulo_CheckedChanged(object sender, EventArgs e)
        {
            if (Articulo.Checked == true)
            {
                Clases.Articulos.CBBuscarArticulo(CBBuscar);
                Clases.Variables.CheckSeleccionado = "0";
                Clases.Variables.FamiliaSeleccionada = "0";
            }
        }
        
        private void Familia_CheckedChanged(object sender, EventArgs e)
        {
            if (Familia.Checked == true && SinFactura.Checked == false)
            {
                Clases.Articulos.CBArticulosFamilia(CBBuscar);
                Clases.Variables.CheckSeleccionado = "1";
                Clases.Variables.FamiliaSeleccionada = "1";
            }
        }

        private void Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (Empleado.Checked == true)
            {
                Clases.Empleados.CBNombre(CBBuscar);
                Clases.Variables.CheckSeleccionado = "0";
                Clases.Variables.FamiliaSeleccionada = "0";
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (CBBuscar.SelectedIndex >= 0)
            {
                if (Articulo.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, CatArticulos.Descripcion AS Articulo," +
                       "Familia.Descripcion as Familia, empleados.Nombre AS Resguardo,bienes.FechaCompra,bienes.Total " +
                       "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                       "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                       "CatArticulos.IdFamilia = Familia.Id where CatArticulos.Descripcion='" + CBBuscar.Text + "' and"+factura;
                else if (Empleado.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, CatArticulos.Descripcion AS Articulo," +
                       "Familia.Descripcion as Familia, empleados.Nombre AS Resguardo,bienes.FechaCompra,bienes.Total " +
                       "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                       "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                       "CatArticulos.IdFamilia = Familia.Id where empleados.Nombre='" + CBBuscar.Text + "' and" + factura;
                else if (Familia.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, CatArticulos.Descripcion AS Articulo," +
                       "Familia.Descripcion as Familia, empleados.Nombre AS Resguardo,bienes.FechaCompra,bienes.Total " +
                       "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                       "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                       "CatArticulos.IdFamilia = Familia.Id where Familia.Descripcion='" + CBBuscar.Text + "' and" + factura;
                else if (Departamento.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, CatArticulos.Descripcion AS Articulo," +
                       "Familia.Descripcion as Familia, empleados.Nombre AS Resguardo,bienes.FechaCompra,bienes.Total " +
                       "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                       "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                       "CatArticulos.IdFamilia = Familia.Id where empleados.Departamento='" + CBBuscar.Text + "' and" + factura;
                if(Clases.Variables.CheckSeleccionado=="1")
                {
                    Clases.Variables.FamiliaSeleccionada = CBBuscar.Text;
                }
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
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, CatArticulos.Descripcion AS Articulo," +
               "Familia.Descripcion as Familia, empleados.Nombre AS Resguardo,bienes.FechaCompra,bienes.Total " +
               "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
               "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
               "CatArticulos.IdFamilia = Familia.Id where"+factura+" order by Familia";
            Clases.Variables.CheckSeleccionado = "0";
            Clases.Variables.FamiliaSeleccionada = "0";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Departamento_CheckedChanged(object sender, EventArgs e)
        {
            if (Departamento.Checked == true)
            {
                Clases.Empleados.CBDeptos(CBBuscar);
                Clases.Variables.CheckSeleccionado = "0";
                Clases.Variables.FamiliaSeleccionada = "0";
            }
        }

        private void ConFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (ConFactura.Checked==true)
                factura = " bienes.NoFactura<>''";
        }

        private void SinFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (SinFactura.Checked == true)
            {
                factura = " bienes.NoFactura=''";
                Clases.Variables.CheckSeleccionado = "0";
                Clases.Variables.FamiliaSeleccionada = "0";
            }
        }
    }
}
