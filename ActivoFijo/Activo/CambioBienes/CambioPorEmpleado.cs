using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivoFijo.Activo.CambioBienes
{
    public partial class CambioPorEmpleado : Form
    {
        public CambioPorEmpleado()
        {
            InitializeComponent();
        }

        private void CambioPorEmpleado_Load(object sender, EventArgs e)
        {
            Clases.Bienes.CBCambio(CBIzquierdo);
            Clases.Bienes.CBCambio(CBDerecho);
        }
        public void ComprobarIzquierda()
        {
            if (CBIzquierdo.SelectedIndex >= 0 && CBDerecho.SelectedIndex >= 0 && CBIzquierdo.SelectedIndex != CBDerecho.SelectedIndex)
            {
                PasarIzquierda.Enabled = true;
                TodoIzquierda.Enabled = true;
                PasarDerecha.Enabled = true;
                TodoDerecha.Enabled = true;
                if (GridIzquierdo.Rows.Count > 0 && GridDerecho.Rows.Count == 0)
                {
                    PasarIzquierda.Enabled = true;
                    TodoIzquierda.Enabled = true;
                    PasarDerecha.Enabled = false;
                    TodoDerecha.Enabled = false;
                }
                else if (GridDerecho.Rows.Count > 0 && GridIzquierdo.Rows.Count == 0)
                {
                    PasarDerecha.Enabled = true;
                    TodoDerecha.Enabled = true;
                    PasarIzquierda.Enabled = false;
                    TodoIzquierda.Enabled = false;
                }
                else if (GridDerecho.Rows.Count == 0 && GridIzquierdo.Rows.Count == 0)
                {
                    PasarIzquierda.Enabled = false;
                    TodoIzquierda.Enabled = false;
                    PasarDerecha.Enabled = false;
                    TodoDerecha.Enabled = false;
                }
            }
            else
            {
                PasarIzquierda.Enabled = false;
                TodoIzquierda.Enabled = false;
                PasarDerecha.Enabled = false;
                TodoDerecha.Enabled = false;
            }
        }

        public void ComprobarDerecha()
        {
            if (CBIzquierdo.SelectedIndex >= 0 && CBDerecho.SelectedIndex >= 0 && CBIzquierdo.SelectedIndex != CBDerecho.SelectedIndex)
            {
                PasarIzquierda.Enabled = true;
                TodoIzquierda.Enabled = true;
                PasarDerecha.Enabled = true;
                TodoDerecha.Enabled = true;
                if (GridIzquierdo.Rows.Count > 0 && GridDerecho.Rows.Count == 0)
                {
                    PasarIzquierda.Enabled = true;
                    TodoIzquierda.Enabled = true;
                    PasarDerecha.Enabled = false;
                    TodoDerecha.Enabled = false;
                }
                else if (GridDerecho.Rows.Count > 0 && GridIzquierdo.Rows.Count == 0)
                {
                    PasarDerecha.Enabled = true;
                    TodoDerecha.Enabled = true;
                    PasarIzquierda.Enabled = false;
                    TodoIzquierda.Enabled = false;
                }
                else if (GridDerecho.Rows.Count == 0 && GridIzquierdo.Rows.Count == 0)
                {
                    PasarIzquierda.Enabled = false;
                    TodoIzquierda.Enabled = false;
                    PasarDerecha.Enabled = false;
                    TodoDerecha.Enabled = false;
                }
            }
            else
            {
                PasarIzquierda.Enabled = false;
                TodoIzquierda.Enabled = false;
                PasarDerecha.Enabled = false;
                TodoDerecha.Enabled = false;
            }
        }

        private void CBIzquierdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");
            ComprobarIzquierda();
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

        private void CBDerecho_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");
            ComprobarDerecha();
        }

        private void PasarIzquierda_Click(object sender, EventArgs e)
        {
            string message = "¿Esta seguro de que desea realizar el cambio?";
            string caption = "Traspaso de bienes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                    CBDerecho.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                    CBIzquierdo.SelectedItem.ToString() + "') and Etiqueta=" + GridIzquierdo.CurrentRow.Cells[0].Value.ToString() + ";";

                string SqlString2 = "insert into HistoricoBienes values (" + Id() + "," + GridIzquierdo.CurrentRow.Cells[0].Value.ToString() + ",(" +
                    "Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "'),(convert('" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " 00:00:00',DATETIME)));";
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
                        using (MySqlCommand cmd = new MySqlCommand(SqlString2, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

                    Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");
                    ComprobarIzquierda();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                    DateTime hoy = DateTime.Today;
                }
            }
        }

        private void PasarDerecha_Click(object sender, EventArgs e)
        {
            string message = "¿Esta seguro de que desea realizar el cambio?";
            string caption = "Traspaso de bienes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                    CBIzquierdo.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                    CBDerecho.SelectedItem.ToString() + "') and Etiqueta=" + GridDerecho.CurrentRow.Cells[0].Value.ToString() + ";";

                string SqlString2 = "insert into HistoricoBienes values (" + Id() + "," + GridDerecho.CurrentRow.Cells[0].Value.ToString() + ",(" +
                    "Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "'),(convert('" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " 00:00:00',DATETIME)));";
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
                        using (MySqlCommand cmd = new MySqlCommand(SqlString2, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

                    Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");
                    ComprobarDerecha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                    DateTime hoy = DateTime.Today;
                }
            }
        }

        private void TodoIzquierda_Click(object sender, EventArgs e)
        {
            string message = "¿Esta seguro de que desea traspasar todos los bienes de este empleado?";
            string caption = "Traspaso de bienes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                string ConnString = Clases.Variables.scon;
                try
                {
                    for (int i = 0; i < GridIzquierdo.RowCount; i++)
                    {
                        string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                     CBDerecho.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                     CBIzquierdo.SelectedItem.ToString() + "') and Etiqueta=" + GridIzquierdo.Rows[i].Cells[0].Value.ToString() + ";";

                        string SqlString2 = "insert into HistoricoBienes values (" + Id() + "," + GridIzquierdo.Rows[i].Cells[0].Value.ToString() + ",(" +
                            "Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "'),(convert('" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " 00:00:00',DATETIME)));";
                        using (MySqlConnection conn = new MySqlConnection(ConnString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(SqlString, conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                            using (MySqlCommand cmd = new MySqlCommand(SqlString2, conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                    }
                    Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

                    Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");
                    ComprobarIzquierda();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                    DateTime hoy = DateTime.Today;
                }
            }
        }

        private void TodoDerecha_Click(object sender, EventArgs e)
        {
            string message = "¿Esta seguro de que desea traspasar todos los bienes de este empleado?";
            string caption = "Traspaso de bienes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                string ConnString = Clases.Variables.scon;
                try
                {
                    for (int i = 0; i < GridDerecho.RowCount; i++)
                    {
                        string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                     CBIzquierdo.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                     CBDerecho.SelectedItem.ToString() + "') and Etiqueta=" + GridDerecho.Rows[i].Cells[0].Value.ToString() + ";";

                        string SqlString2 = "insert into HistoricoBienes values (" + Id() + "," + GridDerecho.Rows[i].Cells[0].Value.ToString() + ",(" +
                            "Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "'),(convert('" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + " 00:00:00',DATETIME)));";
                        using (MySqlConnection conn = new MySqlConnection(ConnString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(SqlString, conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                            using (MySqlCommand cmd = new MySqlCommand(SqlString2, conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                    }
                    Clases.LLenadoGrids.llenarGrid(GridIzquierdo, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "')", "bienes");

                    Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                    "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                    " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");
                    ComprobarDerecha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El cambio no pudo llevarse a cabo. \n" + ex.ToString());
                    DateTime hoy = DateTime.Today;
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
