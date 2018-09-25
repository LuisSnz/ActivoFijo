using System;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Familias
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Desccripcion.Text.Length > 0 && Saldo.Text.Length > 0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "INSERT INTO familia (id,Descripcion,Saldo_Inicial) SELECT 1 + COALESCE((SELECT MAX(id) FROM familia), 0),'" + Desccripcion.Text +
                    "'," + Saldo.Text + ";";
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
                MessageBox.Show("Los campos deben contener un valor");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Saldo_Leave(object sender, EventArgs e)
        {
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(Saldo.Text, out numero);
            if ((!(bln)) && Saldo.Text.Length > 0)
            {
                Saldo.Clear();
                MessageBox.Show("Saldo Incorrecto");
            }
        }
    }
}
