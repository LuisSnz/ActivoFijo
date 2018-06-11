using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Auxiliares.Confirmacion confirmacion = new Auxiliares.Confirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from DEPTOS where Clave=" + Clases.Variables.IdDeptos;
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    MySqlCommand cmd = new MySqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Departamento eliminado correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridDeptos, Clases.Variables.ConsultaBuscar, "DEPTOS");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
        }
    }
}
