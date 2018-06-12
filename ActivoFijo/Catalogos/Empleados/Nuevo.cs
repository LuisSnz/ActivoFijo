using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivoFijo.Catalogos.Empleados
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            FechaVencimiento.Value = DateTime.Now;
            Clases.Empleados.CBJefe(comboJefe);
            Clases.Empleados.CBDeptos(comboDepto);
        }

        public string NoJefe()
        {
            MySqlCommand cmd;
            MySqlDataReader dr;
            string x = "";
            MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select NoEmp from empleados where empleados.Nombre ='" + comboJefe.SelectedItem + "';", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    x = dr["NoEmp"].ToString();
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
            int pliegos = 0, Jefe = 0, Baja = 0, SinPliego = 0;
            if (checkPliegos.Checked == true)
                pliegos = 1;
            if (checkJefe.Checked == true)
                Jefe = 1;
            if (checkSinPliegos.Checked == true)
                SinPliego = 1;
            if (checkBaja.Checked == true)
                Baja = 1;

            if (Nombre.Text.Length > 0 && NombreM.Text.Length > 0 && comboDepto.SelectedIndex >= 0
                && NumLicencia.Text.Length > 0 && comboJefe.SelectedIndex >= 0 && Paterno.Text.Length>0 && Materno.Text.Length>0 )
            {
                string nombres = Nombre.Text;
                string paterno = Paterno.Text;
                string materno = Materno.Text;
                string NombreEmpleado = nombres + " " + paterno + " " + materno;
                string SqlString = "Insert Into empleados (NoEmp,Nombre,Departamento,JefeDepto,NombrePliegos,NoLicencia," +
                    "FechaVencimiento,Bloqueado,Textobloqueado,Baja,NoEmpleadoJefe,ActivoPliegos,NoVerifica) " +
                    "SELECT 1 + COALESCE((SELECT MAX(NoEmp) FROM Empleados), 0),'" + NombreEmpleado + "','" + comboDepto.SelectedItem.ToString() + "',"+Jefe+ ",'" + NombreM.Text + "','" + NumLicencia.Text + "'," +
                    "(convert('" + FechaVencimiento.Value.Year + "-" + FechaVencimiento.Value.Month + "-" + FechaVencimiento.Value.Day + " 00:00:00',datetime)),1,'',"+Baja+ "," + NoJefe() + "," + pliegos + "," + SinPliego + ";";

                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Empleado agregado correctamente");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error inesperado \n"+Clases.Variables.Error);
            }
            else
                MessageBox.Show("Todos los campos deben contener un valor valido");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
