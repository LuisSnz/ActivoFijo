using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ActivoFijo.Activo.Bienes
{
    public partial class ModificarBienes : Form
    {
        public ModificarBienes()
        {
            InitializeComponent();
        }

        private void ModificarBienes_Load(object sender, EventArgs e)
        {
            if (Clases.Variables.BienesConsumible == "True")
                Consumible.Checked = true;
            Clases.Articulos.CBBuscarArticulo(Articulo);
            Clases.Bienes.CBProveedor(Proveedor);
            Clases.Bienes.CBMarca(Marca);
            Clases.Bienes.Modificar(Orden, Fecha, Factura, Articulo, Familia, Marca, Serie, Conservacion,
                Modelo, Color, Proveedor, Domicilio, RFC, Observaciones);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            int TFConsumible = 0;
            if (Consumible.Checked == true)
                TFConsumible = 1;
            if (Orden.Text.Length > 0 && Factura.Text.Length > 0 && Orden.Text.Length > 0 && Articulo.SelectedIndex >= 0 &&
                Marca.SelectedIndex >= 0 && Conservacion.SelectedIndex >= 0 && Proveedor.SelectedIndex >= 0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update bienes set NoOrden=" + Orden.Text + ",NoFactura='" + Factura.Text + "'," +
                    "IdArticulo=(Select Id from CatArticulos where Descripcion='" + Articulo.SelectedItem.ToString() +
                    "'),Observacion='" + Observaciones.Text + "',IdProveedor=(Select Id from Proveedores where Nombre='" +
                    Proveedor.SelectedItem.ToString() + "'),FechaCompra=(convert(datetime,'" + Fecha.Text + "'))," +
                    "IdMarca=(Select TOP 1 Id from marca where Descripcion='" + Marca.SelectedItem.ToString() + "')," +
                    "Serie='" + Serie.Text + "',Modelo='" + Modelo.Text + "',Color='" + Modelo.Text + "',Consumible=" + TFConsumible +
                    ",Estado='" + Conservacion.SelectedItem.ToString() + "' where Id=" + Clases.Variables.IdBienes + ";";
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Bien modificado correctamente.");
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
            }
            else
                MessageBox.Show("Los campos obligatorios(*) deben contener algun valor");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
