using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Empleados
{
    public partial class BuscarEmpleado : Form
    {
        public BuscarEmpleado()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (radioNombre.Checked == true)
            {
                if (comboBuscar.SelectedIndex >= 0)
                {
                    Clases.Variables.ConsultaBuscar = "select NoEmp, Nombre, Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                                "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' " +
                                "from empleados where Nombre LIKE '%" + comboBuscar.Text + "%'";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Seleccione un valor a buscar");
            }
            else if (radioDeptos.Checked == true)
            {
                Clases.Variables.ConsultaBuscar = "select NoEmp, Nombre, Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' " +
                            "from empleados where Departamento='" + comboBuscar.Text + "'";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (radioJefe.Checked == true)
            {
                Clases.Variables.ConsultaBuscar = "select NoEmp, Nombre, Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' " +
                            "from empleados where NoEmpleadoJefe=(select NoEmp from empleados where Nombre='" + comboBuscar.Text + "')";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void MostrarTodo_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select NoEmp, Nombre, Departamento, JefeDepto, NoLicencia, FechaVencimiento, " +
                            "NoEmpleadoJefe,Baja,NombrePliegos,Bloqueado,ActivoPliegos,NoVerifica as 'NoValidoPliego' from empleados";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarEmpleado_Load(object sender, EventArgs e)
        {
            Clases.Empleados.CBNombre(comboBuscar);
        }

        private void radioNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNombre.Checked == true)
                Clases.Empleados.CBNombre(comboBuscar);
        }

        private void radioDeptos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDeptos.Checked == true)
                Clases.Empleados.CBDeptos(comboBuscar);
        }

        private void radioJefe_CheckedChanged(object sender, EventArgs e)
        {
            if (radioJefe.Checked == true)
                Clases.Empleados.CBJefe(comboBuscar);
        }
    }
}
