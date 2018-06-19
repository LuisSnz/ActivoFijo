using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Auxiliares
{
    public partial class ReporteResguardoPE : Form
    {
        public ReporteResguardoPE()
        {
            InitializeComponent();
        }

        private void ReporteResguardoPE_Load(object sender, EventArgs e)
        {
            Clases.Empleados.CBNombreSB(CBNombre);
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (CBNombre.SelectedIndex >= 0)
            {
                Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, CatArticulos.Descripcion AS Articulo, Familia.Descripcion as Familia, " +
                    "empleados.Nombre AS Resguardo,bienes.Total, marca.Descripcion as Marca,bienes.Modelo,bienes.Serie,bienes.Color,bienes.NoOrden as Orden, " +
                    "bienes.NoFactura as Factura, bienes.Observacion as Observaciones FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp  " +
                    "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON CatArticulos.IdFamilia = Familia.Id " +
                    "LEFT OUTER JOIN marca on bienes.IdMarca=marca.Id where empleados.Nombre='" + CBNombre.SelectedItem.ToString() + "'";
                Reportes.ResguardoPorEmleado resguardo = new Reportes.ResguardoPorEmleado();
                resguardo.Show();
            }
            else
                MessageBox.Show("Seleccione un empleado");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
