using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Marcas
{
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            GridMarcas.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "select * from marca order by Descripcion";
            Clases.LLenadoGrids.llenarGrid(GridMarcas, Clases.Variables.ConsultaBuscar, "marca");
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Catalogos.Marcas.Nuevo nuevo = new Catalogos.Marcas.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridMarcas, Clases.Variables.ConsultaBuscar, "marca");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.Marcas.Modificar modificar = new Catalogos.Marcas.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridMarcas, Clases.Variables.ConsultaBuscar, "marca");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void GridMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Marcas.Modificar modificar = new Catalogos.Marcas.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridMarcas, Clases.Variables.ConsultaBuscar, "marca");
        }

        private void GridMarcas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridMarcas.CurrentRow;
            Clases.Variables.IDMarcas = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.DescripcionMarcas = filaSeleccionada.Cells[1].Value.ToString();
        }
    }
}
