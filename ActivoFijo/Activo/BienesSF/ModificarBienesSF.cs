using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ActivoFijo.Activo.BienesSF
{
    public partial class ModificarBienesSF : Form
    {
        public ModificarBienesSF()
        {
            InitializeComponent();
        }

        private void ModificarBienesSF_Load(object sender, EventArgs e)
        {
            if (Clases.Variables.BienesSFConsumible == "True")
                Consumible.Checked = true;
            Clases.Articulos.CBBuscarArticulo(Articulo);
            Clases.Bienes.CBProveedor(Proveedor);
            Clases.Bienes.CBMarca(Marca);
            Clases.BienesSinFactura.Modificar(Orden, Fecha, Articulo, Familia, Marca, Serie, Conservacion,
                Modelo, Color, Proveedor, Domicilio, RFC, Observaciones);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            int TFConsumible = 0;
            if (Consumible.Checked == true)
                TFConsumible = 1;
            if (Orden.Text.Length > 0 && Articulo.SelectedIndex >= 0 &&
                Marca.SelectedIndex >= 0 && Conservacion.SelectedIndex >= 0 && Proveedor.SelectedIndex >= 0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update bienes set NoOrden=" + Orden.Text + "," +
                    "IdArticulo=(Select Id from CatArticulos where Descripcion='" + Articulo.SelectedItem.ToString() +
                    "'),Observacion='" + Observaciones.Text + "',IdProveedor=(Select Id from Proveedores where Nombre='" +
                    Proveedor.SelectedItem.ToString() + "'),FechaCompra=(convert(datetime,'" + Fecha.Text + "'))," +
                    "IdMarca=(Select TOP 1 Id from marca where Descripcion='" + Marca.SelectedItem.ToString() + "')," +
                    "Serie='" + Serie.Text + "',Modelo='" + Modelo.Text + "',Color='" + Modelo.Text + "',Consumible=" + TFConsumible +
                    ",Estado='" + Conservacion.SelectedItem.ToString() + "' where Id=" + Clases.Variables.IdBienesSF + ";";
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

        private void Orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Articulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Familia.Descripcion as familia from CatArticulos,Familia where Familia.Id=CatArticulos.IdFamilia and CatArticulos.Descripcion='" + Articulo.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Familia.Text = dr["familia"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void Proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select direccion,rfc from proveedores where Nombre='" + Proveedor.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Domicilio.Text = dr["direccion"].ToString();
                    RFC.Text = dr["rfc"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void NArt_Click(object sender, EventArgs e)
        {
            Catalogos.Articulos.Nuevo nuevo = new Catalogos.Articulos.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.Articulos.CBBuscarArticulo(Articulo);
        }

        private void NPor_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Nuevo nuevo = new Catalogos.Proveedores.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.Bienes.CBProveedor(Proveedor);
        }
    }
}
