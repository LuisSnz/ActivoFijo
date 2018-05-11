using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Departamentos
{
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Catalogos.Departamentos.Nuevo nuevo = new Catalogos.Departamentos.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridDeptos, Clases.Variables.ConsultaBuscar, "DEPTOS");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.Departamentos.Modificar modificar = new Catalogos.Departamentos.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridDeptos, Clases.Variables.ConsultaBuscar, "DEPTOS");
        }

        private void GridDeptos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = GridDeptos.CurrentRow;
            Clases.Variables.IdDeptos = filaSeleccionada.Cells[0].Value.ToString();
            Clases.Variables.DescripcionDeptos = filaSeleccionada.Cells[1].Value.ToString();
            Clases.Variables.DireccionDeptos = filaSeleccionada.Cells[2].Value.ToString();
            Clases.Variables.SubDeptos = filaSeleccionada.Cells[3].Value.ToString();
        }

        private void GridDeptos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Departamentos.Modificar modificar = new Catalogos.Departamentos.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridDeptos, Clases.Variables.ConsultaBuscar, "DEPTOS");
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select CLAVE, DESCRIPCION, DIRECCION, SUBDIRECCION from DEPTOS";
            Clases.LLenadoGrids.llenarGrid(GridDeptos, Clases.Variables.ConsultaBuscar, "DEPTOS");
        }
    }
}
