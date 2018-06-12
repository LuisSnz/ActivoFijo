using System;
using System.Windows.Forms;

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
            if (Clases.Variables.EmpleadosBaja == "1")
                checkBaja.Checked = true;
            if (Clases.Variables.EmpleadosJefe == "1")
                checkJefe.Checked = true;
            if (Clases.Variables.EmpleadosPliegos == "1")
                checkPliegos.Checked = true;
            if (Clases.Variables.EmpleadosNoPliegos == "1")
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

                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Empleado modificado correctamente");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error inesperado \n" + Clases.Variables.Error);
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
