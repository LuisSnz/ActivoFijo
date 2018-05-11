using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void CBDerecho_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.LLenadoGrids.llenarGrid(GridDerecho, "Select bienes.Etiqueta, CatArticulos.Descripcion, Bienes.total as Precio," +
                "bienes.Observacion from bienes inner join CatArticulos ON bienes.IdArticulo=CatArticulos.Id" +
                " where bienes.NoEmpleado=(Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "')", "bienes");
            ComprobarDerecha();
        }

        private void PasarIzquierda_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.Variables.scon;
            string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                CBDerecho.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                CBIzquierdo.SelectedItem.ToString() + "') and Etiqueta=" + GridIzquierdo.CurrentRow.Cells[0].Value.ToString() + ";";

            string SqlString2 = "insert into HistoricoBienes values (" + GridIzquierdo.CurrentRow.Cells[0].Value.ToString() + ",(" +
                "Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "'),(convert(datetime,'" + DateTime.Today.ToShortDateString() + "')));";
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
                    using (SqlCommand cmd = new SqlCommand(SqlString2, conn))
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

        private void PasarDerecha_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.Variables.scon;
            string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                CBIzquierdo.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                CBDerecho.SelectedItem.ToString() + "') and Etiqueta=" + GridDerecho.CurrentRow.Cells[0].Value.ToString() + ";";

            string SqlString2 = "insert into HistoricoBienes values (" + GridDerecho.CurrentRow.Cells[0].Value.ToString() + ",(" +
                "Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "'),(convert(datetime,'" + DateTime.Today.ToShortDateString() + "')));";
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
                    using (SqlCommand cmd = new SqlCommand(SqlString2, conn))
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

        private void TodoIzquierda_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.Variables.scon;
            try
            {
                for (int i = 0; i < GridIzquierdo.RowCount; i++)
                {
                    string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                 CBDerecho.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                 CBIzquierdo.SelectedItem.ToString() + "') and Etiqueta=" + GridIzquierdo.Rows[i].Cells[0].Value.ToString() + ";";

                    string SqlString2 = "insert into HistoricoBienes values (" + GridIzquierdo.Rows[i].Cells[0].Value.ToString() + ",(" +
                        "Select NoEmp from empleados where Nombre='" + CBDerecho.SelectedItem.ToString() + "'),(convert(datetime,'" + DateTime.Today.ToShortDateString() + "')));";
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        using (SqlCommand cmd = new SqlCommand(SqlString2, conn))
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

        private void TodoDerecha_Click(object sender, EventArgs e)
        {
            string ConnString = Clases.Variables.scon;
            try
            {
                for (int i = 0; i < GridDerecho.RowCount; i++)
                {
                    string SqlString = "Update bienes set NoEmpleado=(select NoEmp from empleados where Nombre='" +
                 CBIzquierdo.SelectedItem.ToString() + "') where NoEmpleado=(select NoEmp from empleados where Nombre='" +
                 CBDerecho.SelectedItem.ToString() + "') and Etiqueta=" + GridDerecho.Rows[i].Cells[0].Value.ToString() + ";";

                    string SqlString2 = "insert into HistoricoBienes values (" + GridDerecho.Rows[i].Cells[0].Value.ToString() + ",(" +
                        "Select NoEmp from empleados where Nombre='" + CBIzquierdo.SelectedItem.ToString() + "'),(convert(datetime,'" + DateTime.Today.ToShortDateString() + "')));";
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        using (SqlCommand cmd = new SqlCommand(SqlString2, conn))
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
