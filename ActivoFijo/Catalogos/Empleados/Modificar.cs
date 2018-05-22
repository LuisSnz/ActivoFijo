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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            if (Clases.Variables.EmpleadosBaja == "True")
                checkBaja.Checked = true;
            if (Clases.Variables.EmpleadosJefe == "True")
                checkJefe.Checked = true;
            if (Clases.Variables.EmpleadosPliegos == "True")
                checkPliegos.Checked = true;
            if (Clases.Variables.EmpleadosNoPliegos == "True")
                checkSinPliegos.Checked = true;
            Clases.Empleados.CBJefe(comboJefe);
            Clases.Empleados.CBDeptos(comboDepto);
            Nombre.Text = Clases.Variables.EmpleadosNombre;
            NombreM.Text = Clases.Variables.EmpleadosNombreP;
            Fecha.Value = Convert.ToDateTime(Clases.Variables.EmpleadosFecha);
            Clases.Empleados.BuscarJefe(comboJefe, Clases.Variables.EmpleadosNumJefe);
            int index = comboDepto.FindString(Clases.Variables.EmpleadosDepto);
            comboDepto.SelectedIndex = index;
            NumLicencia.Text = Clases.Variables.EmpleadosLicencia;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            int pliegos = 0, Jefe = 0, Baja = 0, SinPliego = 0;
            if (checkPliegos.Checked == true)
                pliegos = 1;
            if (checkJefe.Checked == true)
                Jefe = 1;
            if (checkSinPliegos.Checked == true)
                SinPliego = 1;
            if (checkBaja.Checked == true)
                Baja = 1;

            if (Nombre.Text.Length > 0 && NombreM.Text.Length > 0 && comboDepto.SelectedIndex >= 0
               && NumLicencia.Text.Length > 0 && comboJefe.SelectedIndex >= 0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update empleados set Nombre='" + Nombre.Text + "',NombrePliegos='" + NombreM.Text +
                    "',Departamento='" + comboDepto.SelectedItem.ToString() + "',NoLicencia='" + NumLicencia.Text +
                    "',FechaVencimiento=(convert(datetime,'" + Fecha.Text + "')),NoEmpleadoJefe=(select NoEmp from empleados" +
                    " where Nombre='" + comboJefe.SelectedItem.ToString() + "'),ActivoPliegos=" + pliegos + ",JefeDepto=" + Jefe
                    + ",Baja=" + Baja + ",NoVerifica=" + SinPliego + ",Bloqueado=0,Textobloqueado=''" +
                    "where NoEmp=" + Clases.Variables.IdEmpleados + ";";
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Empleado modificado correctamente.");
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
                MessageBox.Show("Todos los campos deben contener un valor valido");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
