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
    public partial class ValorEnBienes : Form
    {
        public ValorEnBienes()
        {
            InitializeComponent();
        }

        private void ValorEnBienes_Load(object sender, EventArgs e)
        {
            GridCosto.Height = Clases.Variables.GridHeight - 40;
            label1.Location = new Point(20, Clases.Variables.GridHeight + 30);
            Total.Location = new Point(140, Clases.Variables.GridHeight + 30);
            label2.Location = new Point(600, Clases.Variables.GridHeight + 30);
            LBTotalBienes.Location = new Point(730, Clases.Variables.GridHeight + 30);
            Clases.Variables.ConsultaBuscar = "SELECT bienes.Etiqueta, CatArticulos.Descripcion AS Articulo," +
               "Familia.Descripcion as Familia, empleados.Nombre AS Resguardo,bienes.Total " +
               "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
               "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
               "CatArticulos.IdFamilia = Familia.Id";
            Clases.LLenadoGrids.llenarGrid(GridCosto, Clases.Variables.ConsultaBuscar, "bienes");
            Clases.Bienes.Suma(Total);
            LBTotalBienes.Text = GridCosto.RowCount.ToString();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Clases.Excel.GridViewExcel(GridCosto);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            BuscarValor buscar = new BuscarValor();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
            {
                Clases.LLenadoGrids.llenarGrid(GridCosto, Clases.Variables.ConsultaBuscar, "bienes");
                float x = 0;
                foreach (DataGridViewRow row in GridCosto.Rows)
                {
                    x = x + float.Parse(row.Cells[4].Value.ToString());
                }
                Total.Text = x.ToString("C");
                Clases.Variables.Total = Total.Text;

            }
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            ReporteValor reporte = new ReporteValor();
            reporte.Show();
        }
    }
}
