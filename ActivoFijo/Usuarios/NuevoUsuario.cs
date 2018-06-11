using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivoFijo.Usuarios
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            Clases.Empleados.CBNombreSB(Empleado);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Empleado.SelectedIndex > 0 && Usuario.Text.Length > 0 && Contraseña.Text.Length > 0 && XContraseña.Text.Length > 0)
                if (Contraseña.Text == XContraseña.Text)
                {
                    string ConnString = Clases.Variables.scon;
                    string SqlString = "Insert Into Usuarios values ((Select NoEmp from empleados where Nombre='"+
                        Empleado.SelectedItem.ToString()+"'),'"+Usuario.Text.ToUpper()+"','"+Contraseña.Text+"'," +
                        " 0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0," +
                        "NULL,NULL,NULL);";
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(ConnString);
                        MySqlCommand cmd = new MySqlCommand(SqlString, conn);
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Usuario agregado correctamente.");
                        this.Close();
                        this.DialogResult = DialogResult.OK;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar nuevo usuario. \n" + ex.ToString());
                    }
                }
                else
                    MessageBox.Show("Ambos campos de contraseña deben ser identicos.");
            else
                MessageBox.Show("Todos los campos deben ser llenados.");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
