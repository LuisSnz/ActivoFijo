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
                try
                {
                    SqlConnection conn = new SqlConnection(ConnString);
                    SqlCommand cmd = new SqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Articulo agregado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
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
