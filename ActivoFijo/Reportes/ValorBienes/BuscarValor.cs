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
        public BuscarValor()
        {
            InitializeComponent();
        }

        private void BuscarValor_Load(object sender, EventArgs e)
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

        private void Familia_CheckedChanged(object sender, EventArgs e)
        {
            if (Familia.Checked == true)
                Clases.Articulos.CBArticulosFamilia(CBBuscar);
        }

        private void Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (Empleado.Checked == true)
                Clases.Empleados.CBNombre(CBBuscar);
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (CBBuscar.SelectedIndex >= 0)
            {
                if (Etiqueta.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, dbo.CatArticulos.Descripcion AS Articulo," +
                       "Familia.Descripcion as Familia, empleados.Nombre AS Empleado,bienes.Total " +
                       "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                       "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                       "CatArticulos.IdFamilia = Familia.Id where bienes.Etiqueta=" + CBBuscar.Text;
                else if (Articulo.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, dbo.CatArticulos.Descripcion AS Articulo," +
                       "Familia.Descripcion as Familia, empleados.Nombre AS Empleado,bienes.Total " +
                       "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                       "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                       "CatArticulos.IdFamilia = Familia.Id where CatArticulos.Descripcion='" + CBBuscar.Text + "'";
                else if (Empleado.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, dbo.CatArticulos.Descripcion AS Articulo," +
                       "Familia.Descripcion as Familia, empleados.Nombre AS Empleado,bienes.Total " +
                       "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                       "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                       "CatArticulos.IdFamilia = Familia.Id where empleados.Nombre='" + CBBuscar.Text + "'";
                else if (Familia.Checked == true)
                    Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, dbo.CatArticulos.Descripcion AS Articulo," +
                       "Familia.Descripcion as Familia, empleados.Nombre AS Empleado,bienes.Total " +
                       "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                       "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                       "CatArticulos.IdFamilia = Familia.Id where Familia.Descripcion='" + CBBuscar.Text + "'";
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
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, dbo.CatArticulos.Descripcion AS Articulo," +
               "Familia.Descripcion as Familia, empleados.Nombre AS Empleado,bienes.Total " +
               "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
               "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
               "CatArticulos.IdFamilia = Familia.Id";
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
