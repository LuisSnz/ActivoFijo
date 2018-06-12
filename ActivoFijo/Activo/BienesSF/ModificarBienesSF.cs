using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            if (Clases.Variables.BienesSFConsumible == "1")
                Consumible.Checked = true;
            Clases.Articulos.CBBuscarArticulo(Articulo);
            Clases.Bienes.CBProveedor(Proveedor);
            Clases.Bienes.CBMarca(Marca);
            Clases.BienesSinFactura.Modificar(Orden, Fecha, Articulo, Familia, Marca, Serie, Conservacion,
                Modelo, Color, Proveedor, Domicilio, RFC, Observaciones);
        }

        public string XArticulo()
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            string x = "";
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select id from CatArticulos where descripcion='" + Articulo.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    x = dr["id"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
            return x;
        }

        public string XMarca()
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            string x = "";
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select id from marca where descripcion='" + Marca.SelectedItem + "' LIMIT 1", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    x = dr["id"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
            return x;
        }
        public string XProveedor()
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            string x = "";
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select id from proveedores where nombre='" + Proveedor.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    x = dr["id"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
            return x;
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
                    "IdArticulo=" + XArticulo() + ",Observacion='" + Observaciones.Text + "',IdProveedor=" + XProveedor() + ",FechaCompra=(" +
                    "convert('" + Fecha.Value.Year.ToString() + "-" + Fecha.Value.Month.ToString() + "-" + Fecha.Value.Day.ToString() + " 00:00:00',DATETIME))," +
                    "IdMarca=" + XMarca() + "," + "Serie='" + Serie.Text + "',Modelo='" + Modelo.Text + "',Color='" + Modelo.Text + "',Consumible=" + TFConsumible +
                    ",Estado='" + Conservacion.SelectedItem.ToString() + "' where Id=" + Clases.Variables.IdBienesSF + ";";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(SqlString, conn))
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
            MySqlCommand cmd;
            MySqlDataReader dr;
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select Familia.Descripcion as familia from CatArticulos,Familia where Familia.Id=CatArticulos.IdFamilia and CatArticulos.Descripcion='" + Articulo.SelectedItem + "'", cn);
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
            MySqlCommand cmd;
            MySqlDataReader dr;
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select direccion,rfc from proveedores where Nombre='" + Proveedor.SelectedItem + "'", cn);
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
