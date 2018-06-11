using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            Auxiliares.Confirmacion confirmacion = new Auxiliares.Confirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from Familia where Id=" + Clases.Variables.IDFamilia;
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    MySqlCommand cmd = new MySqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Familia eliminada correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridFamilias, Clases.Variables.ConsultaBuscar, "Familia");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
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
