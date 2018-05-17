using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ActivoFijo.Usuarios
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Actual.Text.Length > 0 && Nueva.Text.Length > 0 && XNueva.Text.Length > 0)
                if (Actual.Text == Clases.Variables.Contraseña)
                    if (Nueva.Text == XNueva.Text)
                    {
                        string ConnString = Clases.Variables.scon;
                        string SqlString = "Update Usuarios set Password='" + Nueva.Text + "' where Usuario='" + Clases.Variables.Usuario.ToUpper() + "';";
                        try
                        {
                            SqlConnection conn = new SqlConnection(ConnString);
                            SqlCommand cmd = new SqlCommand(SqlString, conn);
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Contraseña modificada correctamente.");
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                            Clases.Variables.Contraseña = Nueva.Text;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al cambiar la contraseña. \n" + ex.ToString());
                        }
                    }
                    else
                        MessageBox.Show("Ambos campos de nueva contraseña deben ser identicos.");
                else
                    MessageBox.Show("La contraseña actual no es valida.");
            else
                MessageBox.Show("Porfavor llene todos los campos.");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
