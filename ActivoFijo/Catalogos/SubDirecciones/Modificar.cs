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

namespace ActivoFijo.Catalogos.SubDirecciones
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Descripcion.Text = Clases.Variables.DescripcionSubD;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text.Length > 0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update subdireccion set Descripcion='" + Descripcion.Text + "' where ID=" + Clases.Variables.IdSubD + ";";
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SubDireccion modificada correctamente.");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
            }
            else
                MessageBox.Show("El campo debe contener un valor");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
