using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivoFijo.Activo.BienesSF
{
    public partial class BajaBienesSF : Form
    {
        public BajaBienesSF()
        {
            InitializeComponent();
        }

        private void BajaBienesSF_Load(object sender, EventArgs e)
        {
            Etiqueta.Text = Clases.Variables.BienesSFEtiqueta;
            Empleado.Text = Clases.Variables.BienesSFEmpleado;
            Articulo.Text = Clases.Variables.BienesSFDescripcionArticulo;
            Precio.Text = Clases.Variables.BienesSFTotal;
            Clases.Bienes.BajaLabels(Modelo, Precio, Serie, Marca);
            Clases.Variables.MotivoBaja = "NO FUNCIONA";
        }

        private void NoFunciona_CheckedChanged(object sender, EventArgs e)
        {
            if (NoFunciona.Checked == true)
                Clases.Variables.MotivoBaja = "NO FUNCIONA";
        }

        private void Robo_CheckedChanged(object sender, EventArgs e)
        {
            if (Robo.Checked == true)
                Clases.Variables.MotivoBaja = "ROBO";
        }

        private void Extravio_CheckedChanged(object sender, EventArgs e)
        {
            if (Extravio.Checked == true)
                Clases.Variables.MotivoBaja = "EXTRAVIO";
        }

        private void Donacion_CheckedChanged(object sender, EventArgs e)
        {
            if (Donacion.Checked == true)
                Clases.Variables.MotivoBaja = "DONACION";
        }

        private void Error_CheckedChanged(object sender, EventArgs e)
        {
            if (Error.Checked == true)
                Clases.Variables.MotivoBaja = "ERROR";
        }

        public void Fecha(DateTimePicker fecha)
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("Select FechaCompra AS Fecha from bienes where Etiqueta=" + Etiqueta.Text, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fecha.Value = Convert.ToDateTime(dr["Fecha"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
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
                cmd = new MySqlCommand("SELECT MAX(Id)+1 as Id FROM bajabienes", cn);
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

        private void Aceptar_Click(object sender, EventArgs e)
        {
            DateTimePicker fechac = new DateTimePicker();
            Fecha(fechac);
            string ConnString = Clases.Variables.scon;
            string SqlString;
            if (Clases.Variables.MotivoBaja != "ERROR")
            {
                SqlString = "Insert Into BajaBienes values (" + Id() + "," + Etiqueta.Text + "," + Clases.Variables.BienesSFOrdenCompra + ",''," + Precio.Text + ",0," +
                    Precio.Text + ",'" + Articulo.Text + "','" + Clases.Variables.BienesSFObservacion + "',NULL,'" + Empleado.Text + "'," +
                    "convert('" + fechac.Value.Year + "-" + fechac.Value.Month + "-" + fechac.Value.Day + " 00:00:00',DATETIME)," +
                    "'" + Marca.Text + "','" + Serie.Text + "','" + Modelo.Text + "','" + Clases.Variables.MotivoBaja + "',NULL," +
                    "(convert('" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " 00:00:00',DATETIME)),'" + Observaciones.Text + "',NULL,0," +
                    Clases.Variables.BienesSFConsumible + ",'" + Clases.Variables.Usuario + "');";
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    MySqlCommand cmd = new MySqlCommand(SqlString, conn);   
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    SqlString = "Delete from bienes where Etiqueta=" + Etiqueta.Text;
                    cmd = new MySqlCommand(SqlString, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("La baja se realizo de manera correcta.");
                    this.Close();
                    this.DialogResult = DialogResult.OK;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja el bien: \n" + ex.ToString());
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
