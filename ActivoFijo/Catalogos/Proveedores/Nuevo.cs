using System;
using System.Windows.Forms;

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
                string SqlString = "Insert Into Proveedores (id,Nombre,Direccion,Rfc, Fax, Ciudad,Contacto,Giro,PadronGobierno," +
                    "Certificaciones,Email,Observaciones,Telefono,Accionistas,Curp)  SELECT 1 + COALESCE((SELECT MAX(id) FROM Proveedores), 0),'" + Nombre.Text + "','" + Direccion.Text +
                    "','" + RFC.Text + "','" + Fax.Text + "','" + Ciudad.Text + "','" + Contacto.Text + "','" + Giro.Text + "','" + Padron.Text +
                    "','" + Certificaciones.Text + "','" + eMail.Text + "','" + Observaciones.Text + "','" + Telefono.Text + "','" +
                    Accionistas.Text + "','" + CURP.Text + "';";
                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Proveedor agregado correctamente");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error inesperado \n" + Clases.Variables.Error);
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
