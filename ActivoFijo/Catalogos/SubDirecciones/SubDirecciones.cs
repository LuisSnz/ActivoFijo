using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ActivoFijo.Catalogos.SubDirecciones
{
    public partial class SubDirecciones : Form
    {
        public SubDirecciones()
        {
            InitializeComponent();
        }

        private void SubDirecciones_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select ID, Descripcion from subdireccion";
            Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Catalogos.SubDirecciones.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.SubDirecciones.Modificar modificarSD = new Modificar();
            modificarSD.ShowDialog();
            if (modificarSD.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Auxiliares.Confirmacion confirmacion = new Auxiliares.Confirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from subdireccion where ID=" + Clases.Variables.IdSubD;
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SubDireccion eliminada correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor no se pudo eliminar. \n" + ex.ToString());
                }
            }
        }

        private void GridSubD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.SubDirecciones.Modificar modificarSD = new Modificar();
            modificarSD.ShowDialog();
            if (modificarSD.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void GridSubD_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdSubD = GridSubD.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.DescripcionSubD = GridSubD.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
