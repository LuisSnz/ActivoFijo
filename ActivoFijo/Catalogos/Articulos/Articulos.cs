using System;
using System.Data;
using MySql.Data.MySqlClient;
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
                Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "cararticulos");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.Articulos.Modificar modificar = new Catalogos.Articulos.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "CatArticulos");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Catalogos.Articulos.BuscarArticulo buscar = new Catalogos.Articulos.BuscarArticulo();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "CatArticulos");
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            GVCatArticulos.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "select CatArticulos.Id, CatArticulos.Descripcion as Articulo, Familia.Descripcion as Familia, " +
                "CatArticulos.inventariable as Inventariable, CatArticulos.Medida,TipoArticulo.Descripcion as Tipo, CatArticulos.ActivoContratos as Contrato " +
                "from CatArticulos inner join Familia on Familia.Id=CatArticulos.IdFamilia left outer join TipoArticulo on TipoArticulo.id=CatArticulos.IdTipoArticulo";
            Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "CatArticulos");
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
                Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "CatArticulos");
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            Auxiliares.Confirmacion Confirmacion = new Auxiliares.Confirmacion();
            Confirmacion.ShowDialog();
            if (Confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from CatArticulos where Descripcion='" + Clases.Variables.ArticuloDescripcion + "'";
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    MySqlCommand cmd = new MySqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Articulo eliminado correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GVCatArticulos, Clases.Variables.ConsultaBuscar, "CatArticulos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
        }
    }
}
