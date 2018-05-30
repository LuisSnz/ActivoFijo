using System;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Departamentos
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Clases.Departamentos.CBSubdireccion(comboSubD);
            Clases.Departamentos.CBAreas(comboArea);
            int index = comboArea.FindString(Clases.Variables.DireccionDeptos);
            comboArea.SelectedIndex = index;
            index = comboSubD.FindString(Clases.Variables.SubDeptos);
            comboSubD.SelectedIndex = index;
            Descripcion.Text = Clases.Variables.DescripcionDeptos;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text.Length > 0 && comboArea.SelectedIndex >= 0 && comboSubD.SelectedIndex >= 0)
            {
                if (Descripcion.Text.Length < 50)
                {
                    string ConnString = Clases.Variables.scon;
                    string SqlString = "Update DEPTOS  set DESCRIPCION='" + Descripcion.Text + "', DIRECCION='" +
                        comboArea.SelectedItem.ToString() + "',SUBDIRECCION='" + comboSubD.SelectedItem.ToString() +
                        "' where CLAVE=" + Clases.Variables.IdDeptos + ";";
                    bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                    if (resultado == true)
                    {
                        MessageBox.Show("Departamento modificado correctamente");
                        this.Close();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error inesperado \n" + Clases.Variables.Error);
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
