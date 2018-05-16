﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.Variables.scon;
            string SqlString;
            if (Clases.Variables.MotivoBaja != "ERROR")
            {
                SqlString = "Insert Into BajaBienes values (" + Etiqueta.Text + ",(Select NoOrden from bienes where Etiqueta=" +
                    Etiqueta.Text + "),(Select NoFactura from bienes where Etiqueta=" + Etiqueta.Text + ")," + Precio.Text + ",0," +
                    Precio.Text + ",'" + Articulo.Text + "',(Select Observacion from bienes where Etiqueta=" + Etiqueta.Text
                    + "),NULL,'" + Empleado.Text + "',(Select FechaCompra from bienes where Etiqueta=" + Etiqueta.Text + ")," +
                    "'" + Marca.Text + "','" + Serie.Text + "','" + Modelo.Text + "','" + Clases.Variables.MotivoBaja + "',NULL," +
                    "(convert(datetime,'" + DateTime.Today.ToShortDateString() + "')),'" + Observaciones.Text + "',NULL,0," +
                    "(Select Consumible from bienes where Etiqueta=" + Etiqueta.Text + "),'" + Clases.Variables.Usuario + "');";
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
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