using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivoFijo.Catalogos.Proveedores
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            GridProveedor.Width = Clases.Variables.GridWidth;
            GridProveedor.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "SELECT Id, RTRIM(Nombre) AS Nombre, RTRIM(Direccion) AS 'Direccion'," +
                " Fax, RTRIM(Ciudad) AS 'Ciudad', Contacto, Giro, PadronGobierno, Certificaciones, Email, Observaciones," +
                " Telefono, Accionistas, Curp FROM Proveedores";
            Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Modificar modificar = new Catalogos.Proveedores.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Auxiliares.Confirmacion confirmacion = new Auxiliares.Confirmacion();
            confirmacion.ShowDialog();
            if (confirmacion.DialogResult == DialogResult.OK)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Delete from Proveedores where Id=" + Clases.Variables.IdProveedores;
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    MySqlCommand cmd = new MySqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Proveedor eliminado correctamente.");
                    Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor seleccionado no es valido. \n" + ex.ToString());
                }
            }
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Clases.Excel.GridViewExcel(GridProveedor);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.BuscarProveedores buscar = new BuscarProveedores();
            buscar.ShowDialog();
            if (buscar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.ReporteProveedores viewer = new ReporteProveedores();
            viewer.Show();
        }

        private void GridProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.Proveedores.Modificar modificar = new Catalogos.Proveedores.Modificar();
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }

        private void GridProveedor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdProveedores = GridProveedor.CurrentRow.Cells[0].Value.ToString();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Nuevo nuevo = new Catalogos.Proveedores.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridProveedor, Clases.Variables.ConsultaBuscar, "Proveedores");
        }
    }
}
