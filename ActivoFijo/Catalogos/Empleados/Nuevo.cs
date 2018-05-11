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

namespace ActivoFijo.Catalogos.Empleados
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            FechaVencimiento.Value = DateTime.Now;
            Clases.Empleados.CBJefe(comboJefe);
            Clases.Empleados.CBDeptos(comboDepto);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            int pliegos = 0, Jefe = 0, Baja = 0, SinPliego = 0, Bloqueado = 0;
            if (checkPliegos.Checked == true)
                pliegos = 1;
            if (checkJefe.Checked == true)
                Jefe = 1;
            if (checkSinPliegos.Checked == true)
                SinPliego = 1;
            if (checkBloqueado.Checked == true)
                Bloqueado = 1;
            if (checkBaja.Checked == true)
                Baja = 1;

            if (Nombre.Text.Length > 0 && NombreM.Text.Length > 0 && comboDepto.SelectedIndex >= 0
                && NumLicencia.Text.Length > 0 && comboJefe.SelectedIndex >= 0)
            {
                string ConnString = Clases.Variables.scon;
                string nombres = Nombre.Text;
                string paterno = Paterno.Text;
                string materno = Materno.Text;
                string NombreEmpleado = nombres + " " + paterno + " " + materno;
                string SqlString = "Insert Into empleados (NoEmp,Nombre,Departamento,JefeDepto,NombrePliegos,NoLicencia," +
                    "FechaVencimiento,Bloqueado,Textobloqueado,Baja,NoEmpleadoJefe,ActivoPliegos,NoVerifica) values " +
                    "((select (Max(NoEmp))+1 from empleados),'" + NombreEmpleado + "','" + comboDepto.SelectedItem.ToString() + "'," +
                    Jefe + ",'" + NombreM.Text + "','" + NumLicencia.Text + "',(convert(datetime,'" + FechaVencimiento.Text + "'))," +
                    Bloqueado + ",'" + Motivo.Text + "'," + Baja + ",(select NoEmp from empleados where Nombre='" +
                    comboJefe.SelectedItem.ToString() + "')," + pliegos + "," + SinPliego + ");";
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
                MessageBox.Show("Todos los campos deben contener un valor valido");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
