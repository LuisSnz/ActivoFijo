using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Familias
{
    public partial class Familias : Form
    {
        public Familias()
        {
            InitializeComponent();
        }

        private void Familias_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select Id, Descripcion from Familia";
            Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Catalogos.Familias.Nuevo nuevo = new Catalogos.Familias.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.Familias.Modificar modificar = new Catalogos.Familias.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void GridFamilias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Familias.Modificar modificar = new Catalogos.Familias.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
        }

        private void GridFamilias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridFamilias.CurrentRow;
            Clases.Variables.IDFamilia = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.DescripcionFamilia = filaSeleccionada.Cells[1].Value.ToString();
        }
    }
}
