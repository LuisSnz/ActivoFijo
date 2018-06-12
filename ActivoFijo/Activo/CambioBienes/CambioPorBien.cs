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

namespace ActivoFijo.Activo.CambioBienes
{
    public partial class CambioPorBien : Form
    {
        public CambioPorBien()
        {
            InitializeComponent();
        }

        private void CambioPorBien_Load(object sender, EventArgs e)
        {
            LBId.Text = Clases.Variables.IdCambio;
            LBEtiqueta.Text = Clases.Variables.EtiquetaCambio;
            LBOrdenCompra.Text = Clases.Variables.OrdenCambio;
            TBArticulo.Text = Clases.Variables.ArticuloCambio;
            TBObservaciones.Text = Clases.Variables.ObservacionesCambio;
            TBResguardoA.Text = Clases.Variables.ResguardoCambio;
            TBDepartamentoA.Text = Clases.Variables.DeptoCambio;
            Clases.Bienes.CBCambio(CBNuevoResguardo);
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
                cmd = new MySqlCommand("SELECT MAX(Id)+1 as Id FROM historicobienes", cn);
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

        private void Cambiar_Click(object sender, EventArgs e)
        {
            if (CBNuevoResguardo.SelectedIndex >= 0)
            {
                DateTime hoy = DateTime.Today;
                string ConnString = Clases.Variables.scon;
                string SqlString = "update bienes set NoEmpleado=(select NoEmp from empleados where nombre='" + CBNuevoResguardo.SelectedItem + "') where NoEmpleado=(select NoEmp from empleados where nombre='" + TBResguardoA.Text + "')  and id=" + LBId.Text + "";
                string SqlString1 = "insert into HistoricoBienes (Id,Etiqueta,NoEmpleado,FechaCambio) values (" + Id() + "," + LBEtiqueta.Text + ",(select NoEmp from empleados where nombre='" + CBNuevoResguardo.SelectedItem + "'),(convert('" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " 00:00:00',DATETIME)))";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(SqlString, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        using (MySqlCommand cmd = new MySqlCommand(SqlString1, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            this.Close();
                        }
                        MessageBox.Show("Bien Cambiado correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El valor insertado no es valido. \n" + ex.ToString());
                }
            }
            else
                MessageBox.Show("Favor de Seleccionar un destino del bien");
        }

        private void CBNuevoResguardo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select departamento from empleados where Nombre='" + CBNuevoResguardo.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TBNuevoResguardo.Text = dr["departamento"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }
}
