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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Clases.Proveedores.Modificar(Nombre, Direccion, Fax, Ciudad, Contacto, RFC, CURP, eMail, Telefono,
                Giro, Padron, Certificaciones, Accionistas, Observaciones);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text.Length > 0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update Proveedores  set Nombre='" + Nombre.Text + "',Direccion='" + Direccion.Text + "',Rfc='" + RFC.Text +
                    "', Fax='" + Fax.Text + "', Ciudad='" + Ciudad.Text + "',Curp='" + CURP.Text + "', Contacto='" + Contacto.Text +
                    "',Giro='" + Giro.Text + "', PadronGobierno='" + Padron.Text + "',Telefono='" + Telefono.Text +
                    "', Certificaciones='" + Certificaciones.Text + "',Email='" + eMail.Text + "',Accionistas='" + Accionistas.Text +
                    "',Observaciones='" + Observaciones.Text + "' where Id=" + Clases.Variables.IdProveedores + ";";
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Proveedor modificado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
            }
            else
                MessageBox.Show("Al menos el campo Nombre debe contener un valor");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
