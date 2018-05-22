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

namespace ActivoFijo.Catalogos.Articulos
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Clases.Articulos.CBArticulosFamilia(CBFamilia);
            Clases.Articulos.CBArticulosTipoArticulo(CBArticulo);
            Clases.Articulos.CBArticulosMedida(CBMedida);
            int index = CBArticulo.FindString(Clases.Variables.ArticuloTipo);
            CBArticulo.SelectedIndex = index;
            index = CBFamilia.FindString(Clases.Variables.ArticuloFamilia);
            CBFamilia.SelectedIndex = index;
            index = CBMedida.FindString(Clases.Variables.ArticuloMedida);
            CBMedida.SelectedIndex = index;
            TBArticulo.Text = Clases.Variables.ArticuloDescripcion;
            if (Clases.Variables.ArticuloContrato == "True")
                CHArticuloContrato.Checked = true;
            else
                CHArticuloContrato.Checked = false;
            if (Clases.Variables.ArticuloInventariable == "True")
                CHBInventariable.Checked = true;
            else
                CHBInventariable.Checked = false;
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
                string SqlString = "Update CatArticulos set Descripcion='" + TBArticulo.Text + "',idfamilia=(select id from Familia where Familia.Descripcion ='" + CBFamilia.SelectedItem + "'),ActivoContratos='" + con + "',Medida='" + CBMedida.SelectedItem + "',IdTipoArticulo=(select id from TipoArticulo where descripcion='" + CBArticulo.SelectedItem + "'),inventariable='" + inv + "',IdFamiliaSolicitudes='1',Activo='True',COG='0' where Id=" + Clases.Variables.IdArticulo + "";
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Articulo modificado correctamente.");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
            }
            else
                MessageBox.Show("Los campos deben contener algun valor");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CHBInventariable_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBInventariable.Checked == true)
                CHArticuloContrato.Checked = false;
        }

        private void CHArticuloContrato_CheckedChanged(object sender, EventArgs e)
        {
            if (CHArticuloContrato.Checked == true)
                CHBInventariable.Checked = false;
        }
    }
}
