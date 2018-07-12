using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivoFijo.Catalogos.Areas
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Catalogos.Areas.Nuevo nuevo = new Catalogos.Areas.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridAreas, Clases.Variables.ConsultaBuscar, "areas");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.Areas.Modificar modificar = new Catalogos.Areas.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridAreas, Clases.Variables.ConsultaBuscar, "areas");
        }

        private void Areas_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select Clave, Descripcion from areas";
            Clases.LLenadoGrids.llenarGrid(GridAreas, Clases.Variables.ConsultaBuscar, "areas");
        }

        private void GridAreas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Areas.Modificar modificar = new Catalogos.Areas.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridAreas, Clases.Variables.ConsultaBuscar, "areas");
        }

        private void GridAreas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdAreas = GridAreas.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.DescripcionAreas = GridAreas.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
