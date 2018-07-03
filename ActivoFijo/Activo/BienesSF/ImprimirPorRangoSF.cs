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
    public partial class ImprimirPorRangoSF : Form
    {
        public ImprimirPorRangoSF()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (CBArticulo.SelectedIndex > 0 && CBNombre.SelectedIndex > 0)
            {
                try
                {
                    MySqlCommand cmd;
                    MySqlDataReader dr;
                    MySqlDataReader dr1;
                    MySqlConnection cn = new MySqlConnection(Clases.Variables.scon);
                    cn.Open();
                    cmd = new MySqlCommand("SELECT COUNT(Etiqueta) as Cantidad,MIN(bienes.Etiqueta) as Minimo,MAX(bienes.Etiqueta) as Maximo, bienes.NoOrden as NoOrden, bienes.serie as Serie, " +
                        "bienes.Total as Total, Familia.Descripcion AS Familia, CatArticulos.Descripcion AS Articulo, empleados.Nombre AS Empleado," +
                        "empleados.Departamento as Departamento, RTRIM(proveedores.Nombre) AS Proveedor, bienes.Observacion AS Observacion " +
                        "FROM bienes INNER JOIN empleados ON bienes.NoEmpleado = empleados.NoEmp " +
                        "INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia ON " +
                        "CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor = Proveedores.Id " +
                        "where CatArticulos.Descripcion = '" + CBArticulo.SelectedItem + "' " +
                        "AND bienes.NoFactura='' AND empleados.Nombre = '" + CBNombre.SelectedItem + "' group by Articulo,Total", cn);

                    dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        cn.Close();
                        cn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Clases.Variables.BienesSFCantidad = dr["Cantidad"].ToString();
                            Clases.Variables.BienesSFEtiqueta = dr["Minimo"].ToString() + " a " + dr["Maximo"].ToString();
                            Clases.Variables.BienesSFOrdenCompra = dr["NoOrden"].ToString();
                            Clases.Variables.BienesSFSerie = dr["Serie"].ToString();
                            Clases.Variables.BienesSFTotal = dr["Total"].ToString();
                            Clases.Variables.BienesSFFamilia = dr["Familia"].ToString();
                            Clases.Variables.BienesSFDescripcionArticulo = dr["Articulo"].ToString();
                            Clases.Variables.BienesSFEmpleado = dr["Empleado"].ToString();
                            Clases.Variables.BienesSFDepartamento = dr["Departamento"].ToString();
                            Clases.Variables.BienesSFObservacion = dr["Observacion"].ToString();
                            ReporteBienesSF reporteBienes = new ReporteBienesSF();
                            reporteBienes.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro coincidencia en la busqueda, intente de nuevo");
                    }
                    cn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los valores introducidos no son validos o no existe esa busqueda");
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImprimirPorRangoSF_Load(object sender, EventArgs e)
        {
            Clases.Empleados.CBNombreSB(CBNombre);
            Clases.Articulos.CBBuscarArticulo(CBArticulo);
        }
    }
}
