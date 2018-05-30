using System;
using System.Windows.Forms;

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
                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Proveedor modificado correctamente");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error inesperado \n" + Clases.Variables.Error);
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
