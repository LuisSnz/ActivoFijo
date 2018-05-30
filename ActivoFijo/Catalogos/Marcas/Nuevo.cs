using System;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Marcas
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text.Length > 0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Insert Into marca (Descripcion) values ('" + Descripcion.Text + "');";
                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Familia agregada correctamente");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error inesperado \n" + Clases.Variables.Error);
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
