using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public string Id()
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            string x = "";
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("SELECT MAX(Id)+1 as Id FROM catarticulos", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    x = dr["Id"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
            return x;
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
                string SqlString = "Insert Into CatArticulos (Id,Descripcion,idfamilia,ActivoContratos,Medida,IdTipoArticulo,inventariable,IdFamiliaSolicitudes,Activo,COG) " +
                    "values ("+Id()+",'" + TBArticulo.Text + "',"+Familia()+",'" + con + "','" + CBMedida.SelectedItem + "',"+Tipo()+",'" + inv + "','1','1','0')";
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
