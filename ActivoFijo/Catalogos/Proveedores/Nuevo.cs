using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ActivoFijo.Catalogos.Proveedores
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text.Length > 0 && Fax.Text.Length>0 && Ciudad.Text.Length>0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Insert Into Proveedores (Nombre,Direccion,Rfc, Fax, Ciudad,Contacto,Giro,PadronGobierno," +
                    "Certificaciones,Email,Observaciones,Telefono,Accionistas,Curp) values ('" + Nombre.Text + "','" + Direccion.Text +
                    "','" + RFC.Text + "','" + Fax.Text + "','" + Ciudad.Text + "','" + Contacto.Text + "','" + Giro.Text + "','" + Padron.Text +
                    "','" + Certificaciones.Text + "','" + eMail.Text + "','" + Observaciones.Text + "','" + Telefono.Text + "','" +
                    Accionistas.Text + "','" + CURP.Text + "');";
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Proveedor agragado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos que contengan un (*) con un valor valido");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
