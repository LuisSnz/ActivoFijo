using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            if (Clases.Variables.ArticuloContrato == "1")
                CHArticuloContrato.Checked = true;
            else
                CHArticuloContrato.Checked = false;
            if (Clases.Variables.ArticuloInventariable == "1")
                CHBInventariable.Checked = true;
            else
                CHBInventariable.Checked = false;
        }

        public string Tipo()
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            string x = "";
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select id from TipoArticulo where descripcion='" + CBArticulo.SelectedItem + "';", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    x = dr["id"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
            return x;
        }

        public string Familia()
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            string x = "";
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select id from Familia where Familia.Descripcion ='" + CBFamilia.SelectedItem + "';", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    x = dr["id"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
            return x;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (TBArticulo.Text.Length > 0 && CBArticulo.SelectedIndex >= 0 && CBFamilia.SelectedIndex >= 0 && CBMedida.SelectedIndex >= 0)
            {
                int con = 0;
                int inv = 0;
                if (CHArticuloContrato.Checked == true)
                    con = 1;
                if (CHBInventariable.Checked == true)
                    inv = 1;
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update CatArticulos set Descripcion='" + TBArticulo.Text + "',idfamilia="+Familia()+",ActivoContratos='" + con + "',Medida='" +
                    CBMedida.SelectedItem + "',IdTipoArticulo="+Tipo()+",inventariable='" +
                    inv + "',IdFamiliaSolicitudes='1',Activo=1,COG='0' where Id=" + Clases.Variables.IdArticulo + "";
                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Articulo modificado correctamente");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error inesperado \n" + Clases.Variables.Error);
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
