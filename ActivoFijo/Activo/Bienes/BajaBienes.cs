﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivoFijo.Activo.Bienes
{
    public partial class BajaBienes : Form
    {
        public BajaBienes()
        {
            InitializeComponent();
        }

        private void BajaBienes_Load(object sender, EventArgs e)
        {
            Etiqueta.Text = Clases.Variables.BienesEtiqueta;
            Empleado.Text = Clases.Variables.BienesEmpleado;
            Articulo.Text = Clases.Variables.BienesDescripcionArticulo;
            Precio.Text = Clases.Variables.BienesTotal;
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
                    fecha.Value =Convert.ToDateTime(dr["Fecha"].ToString());
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

        public string IdE()
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            string x = "";
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("SELECT MAX(Id)+1 as Id FROM bajabienes_Error", cn);
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
                SqlString = "Insert Into BajaBienes values (" + Id() + "," + Etiqueta.Text + "," + Clases.Variables.BienesOrdenCompra + ",'" + Clases.Variables.BienesFactura + "'," + Precio.Text + ",0," +
                    Precio.Text + ",'" + Articulo.Text + "','" + Clases.Variables.BienesObservacion + "',NULL,'" + Empleado.Text + "'," +
                    "convert('" + fechac.Value.Year + "-" + fechac.Value.Month + "-" + fechac.Value.Day + " 00:00:00',DATETIME)," +
                    "'" + Marca.Text + "','" + Serie.Text + "','" + Modelo.Text + "','" + Clases.Variables.MotivoBaja + "',NULL," +
                    "(convert('" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " 00:00:00',DATETIME)),'" + Observaciones.Text + "',NULL,0," +
                    Clases.Variables.BienesConsumible + ",'" + Clases.Variables.Usuario + "');";
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
            else
            {
                SqlString = "Insert Into bajabienes_Error values (" + IdE() + "," + Etiqueta.Text + "," + Clases.Variables.BienesOrdenCompra + ",'" + Clases.Variables.BienesFactura + "'," + Precio.Text + ",0," +
                    Precio.Text + ",'" + Articulo.Text + "','" + Clases.Variables.BienesObservacion + "',NULL,'" + Empleado.Text + "'," +
                    "convert('" + fechac.Value.Year + "-" + fechac.Value.Month + "-" + fechac.Value.Day + " 00:00:00',DATETIME)," +
                    "'" + Marca.Text + "','" + Serie.Text + "','" + Modelo.Text + "','" + Clases.Variables.MotivoBaja + "',NULL," +
                    "(convert('" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " 00:00:00',DATETIME)),'" + Observaciones.Text + "',NULL,0," +
                    Clases.Variables.BienesConsumible + ",'" + Clases.Variables.Usuario + "');";
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