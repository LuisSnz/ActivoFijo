using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ActivoFijo.Clases
{
    class Articulos
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static string conexion = Clases.Variables.scon;
        public static SqlConnection cn = new SqlConnection(conexion);

        public static void CBArticulosFamilia(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from familia", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBArticulosTipoArticulo(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from tipoarticulo", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                //CB.SelectedIndex = 0;
                //dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBArticulosMedida(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from Medida", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBBuscarArticulo(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from CatArticulos order by descripcion", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class Bienes
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static string conexion = Clases.Variables.scon;
        public static SqlConnection cn = new SqlConnection(conexion);

        public static void CBCambio(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select nombre from empleados where Baja=0 order by Nombre", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBMarca(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from marca order by Descripcion", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBEtiqueta(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Etiqueta from bienes", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Etiqueta"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBFactura(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select NoFactura from bienes order by NoFactura", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["NoFactura"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBProveedor(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select RTRIM(Nombre) as Nombre from Proveedores order by Nombre", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void Modificar(TextBox orden, DateTimePicker fecha, TextBox factura, ComboBox articulo,
            Label familia, ComboBox marca, TextBox serie, ComboBox conservacion, TextBox modelo, TextBox color, ComboBox proveedor,
            Label domicilio, Label rfc, TextBox observaciones)
        {
            try
            {
                int index;
                cn.Open();
                cmd = new SqlCommand("SELECT bienes.Id, bienes.NoOrden,bienes.FechaCompra, bienes.NoFactura," +
                    "bienes.Modelo,Bienes.Color,Familia.Descripcion as Familia, dbo.CatArticulos.Descripcion AS Articulo," +
                    "RTRIM(Proveedores.Nombre) AS Proveedor,bienes.Estado,RTRIM(Proveedores.Direccion) AS Direccion," +
                    "RTRIM(Proveedores.Rfc) AS RFC,bienes.Observacion,marca.Descripcion as marca,bienes.Serie " +
                    "FROM bienes INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia " +
                    "ON CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id" +
                    " LEFT OUTER JOIN marca on bienes.IdMarca=marca.Id where bienes.Id=" + Clases.Variables.IdBienes, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    orden.Text = dr["NoOrden"].ToString();
                    fecha.Value = Convert.ToDateTime(dr["FechaCompra"].ToString());
                    factura.Text = dr["NoFactura"].ToString();
                    index = articulo.FindString(dr["Articulo"].ToString());
                    articulo.SelectedIndex = index;
                    familia.Text = dr["Familia"].ToString();
                    index = marca.FindString(dr["marca"].ToString());
                    marca.SelectedIndex = index;
                    serie.Text = dr["Serie"].ToString();
                    index = conservacion.FindString(dr["Estado"].ToString());
                    conservacion.SelectedIndex = index;
                    modelo.Text = dr["Modelo"].ToString();
                    color.Text = dr["Color"].ToString();
                    index = proveedor.FindString(dr["Proveedor"].ToString());
                    proveedor.SelectedIndex = index;
                    domicilio.Text = dr["Direccion"].ToString();
                    rfc.Text = dr["RFC"].ToString();
                    observaciones.Text = dr["Observacion"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void BajaLabels(Label modelo, Label precio, Label serie, Label marca)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT bienes.Id,bienes.Modelo,bienes.Precio,bienes.Serie,marca.Descripcion as marca " +
                    "from bienes inner join marca on bienes.IdMarca=marca.Id where bienes.Id=" + Clases.Variables.IdBienes, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    modelo.Text = dr["Modelo"].ToString();
                    serie.Text = dr["Serie"].ToString();
                    precio.Text = dr["Precio"].ToString();
                    marca.Text = dr["marca"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBDeptos(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct Departamento from empleados", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Departamento"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void Suma(Label Total)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select SUM(total) as Total from bienes", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    float x = float.Parse(dr["Total"].ToString());
                    Total.Text = x.ToString("C");
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class BienesBaja
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static string conexion = Clases.Variables.scon;
        public static SqlConnection cn = new SqlConnection(conexion);

        public static void CBEtiqueta(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Etiqueta from BajaBienes order by Etiqueta", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Etiqueta"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBArticulo(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct RTRIM(Articulo) AS Articulo from BajaBienes order by Articulo", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Articulo"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBEmleado(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct RTRIM(Empleado) AS Empleado from BajaBienes order by Empleado", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Empleado"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBFactura(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct RTRIM(NoFactura) AS Factura from BajaBienes", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Factura"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBMotivo(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct RTRIM(MotivoBaja) AS Motivo from BajaBienes", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Motivo"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class Departamentos
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static string conexion = Clases.Variables.scon;
        public static SqlConnection cn = new SqlConnection(conexion);

        public static void CBAreas(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from areas", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBSubdireccion(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from subdireccion", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class Empleados
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static string conexion = Clases.Variables.scon;
        public static SqlConnection cn = new SqlConnection(conexion);

        public static void CBJefe(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Distinct Nombre from empleados where JefeDepto=1", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        public static void CBDeptos(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select DESCRIPCION from DEPTOS", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["DESCRIPCION"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void BuscarJefe(ComboBox CB, string n)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Nombre from Empleados where NoEmp=" + n, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int index = CB.FindString(dr["Nombre"].ToString());
                    CB.SelectedIndex = index;
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void BuscarMotivo(TextBox TB, string n)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Textobloqueado from Empleados where NoEmp=" + n, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB.Text = dr["Textobloqueado"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBNombre(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Nombre from empleados order by nombre", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class Proveedores
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static string conexion = Clases.Variables.scon;
        public static SqlConnection cn = new SqlConnection(conexion);

        public static void Modificar(TextBox Nombre, TextBox Direccion, TextBox Fax, TextBox Ciudad, TextBox Contacto,
            TextBox RFC, TextBox CURP, TextBox Email, TextBox Telefono, TextBox Giro, TextBox Padron, TextBox Certificacion,
            TextBox Accionistas, TextBox Observaciones)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select RTRIM(Nombre) as 'Nombre',RTRIM(Direccion) as 'Direccion',RTRIM(Fax) as 'Fax'," +
                    "RTRIM(Ciudad) as 'Ciudad',RTRIM(Contacto) as 'Contacto',RTRIM(Rfc) as 'RFC',RTRIM(Curp) as 'CURP'," +
                    "RTRIM(Email) as 'Email',RTRIM(Telefono) as 'Telefono',RTRIM(Giro) as 'Giro',RTRIM(PadronGobierno) as 'Padron'," +
                    "RTRIM(Certificaciones) as 'Certificaciones',RTRIM(Accionistas) as 'Accionistas'," +
                    "RTRIM(Observaciones) as 'Observaciones' from Proveedores where Id=" + Clases.Variables.IdProveedores, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Nombre.Text = dr["Nombre"].ToString();
                    Direccion.Text = dr["Direccion"].ToString();
                    Fax.Text = dr["Fax"].ToString();
                    CURP.Text = dr["CURP"].ToString();
                    Ciudad.Text = dr["Ciudad"].ToString();
                    RFC.Text = dr["RFC"].ToString();
                    Telefono.Text = dr["Telefono"].ToString();
                    Email.Text = dr["Email"].ToString();
                    Contacto.Text = dr["Contacto"].ToString();
                    Giro.Text = dr["Giro"].ToString();
                    Padron.Text = dr["Padron"].ToString();
                    Certificacion.Text = dr["Certificaciones"].ToString();
                    Accionistas.Text = dr["Accionistas"].ToString();
                    Observaciones.Text = dr["Observaciones"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        public static void CBBuscar(ComboBox CB, string Consulta, string Columna)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand(Consulta, cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr[Columna].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class BienesSinFactura
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static string conexion = Clases.Variables.scon;
        public static SqlConnection cn = new SqlConnection(conexion);

        public static void CBEtiqueta(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Etiqueta from bienes where noFactura=''", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Etiqueta"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBProveedor(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select RTRIM(Proveedores.Nombre) as Nombre from Proveedores inner join bienes on " +
                    "bienes.IdProveedor=Proveedores.Id where bienes.noFactura='' order by Nombre", cn);
                dr = cmd.ExecuteReader();
                CB.Text = "";
                CB.Items.Clear();
                while (dr.Read())
                {
                    CB.Items.Add(dr["Nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void Modificar(TextBox orden, DateTimePicker fecha, ComboBox articulo,
            Label familia, ComboBox marca, TextBox serie, ComboBox conservacion, TextBox modelo, TextBox color, ComboBox proveedor,
            Label domicilio, Label rfc, TextBox observaciones)
        {
            try
            {
                int index;
                cn.Open();
                cmd = new SqlCommand("SELECT bienes.Id, bienes.NoOrden,bienes.FechaCompra," +
                    "bienes.Modelo,Bienes.Color,Familia.Descripcion as Familia, dbo.CatArticulos.Descripcion AS Articulo," +
                    "RTRIM(Proveedores.Nombre) AS Proveedor,bienes.Estado,RTRIM(Proveedores.Direccion) AS Direccion," +
                    "RTRIM(Proveedores.Rfc) AS RFC,bienes.Observacion,marca.Descripcion as marca,bienes.Serie " +
                    "FROM bienes INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia " +
                    "ON CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN Proveedores on bienes.IdProveedor=Proveedores.Id" +
                    " LEFT OUTER JOIN marca on bienes.IdMarca=marca.Id where bienes.Id=" + Clases.Variables.IdBienesSF, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    orden.Text = dr["NoOrden"].ToString();
                    fecha.Value = Convert.ToDateTime(dr["FechaCompra"].ToString());
                    index = articulo.FindString(dr["Articulo"].ToString());
                    articulo.SelectedIndex = index;
                    familia.Text = dr["Familia"].ToString();
                    index = marca.FindString(dr["marca"].ToString());
                    marca.SelectedIndex = index;
                    serie.Text = dr["Serie"].ToString();
                    index = conservacion.FindString(dr["Estado"].ToString());
                    conservacion.SelectedIndex = index;
                    modelo.Text = dr["Modelo"].ToString();
                    color.Text = dr["Color"].ToString();
                    index = proveedor.FindString(dr["Proveedor"].ToString());
                    proveedor.SelectedIndex = index;
                    domicilio.Text = dr["Direccion"].ToString();
                    rfc.Text = dr["RFC"].ToString();
                    observaciones.Text = dr["Observacion"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void BajaLabels(Label modelo, Label precio, Label serie, Label marca)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT bienes.Id,bienes.Modelo,bienes.Precio,bienes.Serie,marca.Descripcion as marca " +
                    "from bienes inner join marca on bienes.IdMarca=marca.Id where bienes.Id=" + Clases.Variables.IdBienesSF, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    modelo.Text = dr["Modelo"].ToString();
                    serie.Text = dr["Serie"].ToString();
                    precio.Text = dr["Precio"].ToString();
                    marca.Text = dr["marca"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBBuscarArticulo(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Descripcion from CatArticulos inner join bienes on" +
                    " CatArticulos.Id=bienes.IdArticulo where bienes.noFactura='' order by descripcion", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Descripcion"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
        public static void CBNombre(ComboBox CB)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Nombre from empleados inner join bienes on empleados.NoEmp=bienes.NoEmpleado" +
                    " where bienes.NoFactura='' order by nombre", cn);
                dr = cmd.ExecuteReader();
                CB.Items.Clear();
                CB.Text = "";
                while (dr.Read())
                {
                    CB.Items.Add(dr["Nombre"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }
    }

    class Login
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static string conexion = Clases.Variables.scon;
        public static SqlConnection cn = new SqlConnection(conexion);

        public static int Validacion()
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Usuario, Password from Usuarios where Usuario='"+Variables.Usuario+
                    "' and Password='"+Variables.Contraseña+"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Variables.VUsuario = dr["Usuario"].ToString();
                    Variables.VContraseña = dr["Password"].ToString();
                }
                cn.Close();
                if (Variables.Usuario.ToUpper() == Variables.VUsuario && Variables.Contraseña == Variables.VContraseña)
                    return 1;
                else
                    return 0;
            }
            catch (Exception)
            {
                return 2;
            }
        }
    }
}
