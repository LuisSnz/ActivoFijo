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

namespace ActivoFijo.Catalogos.Departamentos
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            Clases.Departamentos.CBSubdireccion(comboSubd);
            Clases.Departamentos.CBAreas(comboArea);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text.Length > 0 && comboArea.SelectedIndex >= 0 && comboSubd.SelectedIndex >= 0)
            {
                if (Descripcion.Text.Length < 50)
                {
                    string ConnString = Clases.Variables.scon;
                    string SqlString = "Insert Into DEPTOS (CLAVE, DESCRIPCION, DIRECCION, SUBDIRECCION) " +
                        "values ((select (COUNT(clave))+1 from DEPTOS),'" + Descripcion.Text + "', '" +
                        comboArea.SelectedItem.ToString() + "','" + comboSubd.SelectedItem.ToString() + "');";
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConnString);
                        SqlCommand cmd = new SqlCommand(SqlString, conn);
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Departamento agragado correctamente.");
                        this.Close();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("El nombre del departamento debe tener menos de 50 caracteres");
                }
            }
            else
                MessageBox.Show("Todos los campos deben contener un valor");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
