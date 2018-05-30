using System;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Articulos
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            Clases.Articulos.CBArticulosFamilia(CBFamilia);
            Clases.Articulos.CBArticulosTipoArticulo(CBArticulo);
            Clases.Articulos.CBArticulosMedida(CBMedida);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (TBArticulo.Text.Length > 0 && CBArticulo.SelectedIndex >= 0 && CBFamilia.SelectedIndex >= 0 && CBMedida.SelectedIndex >= 0)
            {
                bool con = false;
                bool inv = false;
                if (CHArticuloContrato.Checked == true)
                    con = true;
                if (CHBInventariable.Checked == true)
                    inv = true;
                string ConnString = Clases.Variables.scon;
                string SqlString = "Insert Into CatArticulos (Descripcion,idfamilia,ActivoContratos,Medida,IdTipoArticulo,inventariable,IdFamiliaSolicitudes,Activo,COG) " +
                    "values ('" + TBArticulo.Text + "',(select id from Familia where Familia.Descripcion ='" + CBFamilia.SelectedItem + "'),'" + con + "','" + CBMedida.SelectedItem + "',(select id from TipoArticulo where descripcion='" + CBArticulo.SelectedItem + "'),'" + inv + "','1','True','0')";
                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Articulo agregado correctamente");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error inesperado \n" + Clases.Variables.Error);
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los datos");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CHBInventariable_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBInventariable.Checked==true)
            CHArticuloContrato.Checked = false;
        }

        private void CHArticuloContrato_CheckedChanged(object sender, EventArgs e)
        {
            if (CHArticuloContrato.Checked==true)
            CHBInventariable.Checked = false;
        }
    }
}
