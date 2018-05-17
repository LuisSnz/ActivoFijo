using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Usuarios
{
    public partial class Lista_Usuarios : Form
    {
        public Lista_Usuarios()
        {
            InitializeComponent();
        }

        private void Lista_Usuarios_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "Select empleados.Nombre, Usuarios.Usuario from Usuarios Inner join empleados " +
                "on Usuarios.NoEmpleado=empleados.NoEmp";
            Clases.LLenadoGrids.llenarGrid(GridUsuarios, Clases.Variables.ConsultaBuscar, "Usuarios");
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridUsuarios, Clases.Variables.ConsultaBuscar, "Usuarios");
        }
    }
}
