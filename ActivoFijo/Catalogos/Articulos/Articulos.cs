using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Articulos
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Catalogos.Articulos.Nuevo nuevo = new Catalogos.Articulos.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "vArticulosCompras");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.Articulos.Modificar modificar = new Catalogos.Articulos.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "vArticulosCompras");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Catalogos.Articulos.BuscarArticulo buscar = new Catalogos.Articulos.BuscarArticulo();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "vArticulosCompras");
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            GVCatArticulos.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "select ID,Descripcion,Familia,Inventariable,Medida,TipoArticulo as 'Tipo Articulo',ActivoContratos as 'Activos por Contrato' from vArticulosCompras order by id";
            Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "vArticulosCompras");
        }

        private void GVCatArticulos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdArticulo = GVCatArticulos.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.ArticuloDescripcion = GVCatArticulos.CurrentRow.Cells[1].Value.ToString();
            Clases.Variables.ArticuloFamilia = GVCatArticulos.CurrentRow.Cells[2].Value.ToString();
            Clases.Variables.ArticuloInventariable = GVCatArticulos.CurrentRow.Cells[3].Value.ToString();
            Clases.Variables.ArticuloMedida = GVCatArticulos.CurrentRow.Cells[4].Value.ToString();
            Clases.Variables.ArticuloTipo = GVCatArticulos.CurrentRow.Cells[5].Value.ToString();
            Clases.Variables.ArticuloContrato = GVCatArticulos.CurrentRow.Cells[6].Value.ToString();
        }

        private void GVCatArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Articulos.Modificar modificar = new Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "vArticulosCompras");
        }
    }
}
