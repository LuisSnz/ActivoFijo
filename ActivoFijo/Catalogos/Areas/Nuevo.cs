using System;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Areas
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
                string SqlString = "INSERT INTO areas (Clave,Descripcion) SELECT 1 + COALESCE((SELECT MAX(Clave) FROM areas), 0),('" + Descripcion.Text + "');";
                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Area agregada correctamente");
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
