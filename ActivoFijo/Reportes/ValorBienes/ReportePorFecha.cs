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
    public partial class ReportePorFecha : Form
    {
        public ReportePorFecha()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generar_Click(object sender, EventArgs e)
        {

        Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, CatArticulos.Descripcion AS Articulo," +
               "Familia.Descripcion as Familia, empleados.Nombre AS Resguardo,bienes.FechaCompra,bienes.Total " +
               "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
               "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
               "CatArticulos.IdFamilia = Familia.Id where FechaCompra " +
                "BETWEEN '" + Inicio.Text + "' AND '" + Fin.Text + "' order by FechaCompra ";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
