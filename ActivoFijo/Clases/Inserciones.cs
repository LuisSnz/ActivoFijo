using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ActivoFijo.Clases
{
    class Inserciones
    {
        public static bool Ejecucion(string comando)
        {
            try
            {
                string ConnString = Clases.Variables.scon;
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Clases.Variables.Error = e.ToString();
                return false;
            }
        }
        public static void BEjecucion(string comando)
        {
            try
            {
                string ConnString = Clases.Variables.scon;
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Clases.Variables.ErrorB = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error inesperado \n" + e.ToString());
                Clases.Variables.ErrorB = true;
            }
        }
    }
}
