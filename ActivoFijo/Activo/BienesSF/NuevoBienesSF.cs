using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ActivoFijo.Activo.BienesSF
{
    public partial class NuevoBienesSF : Form
    {
        public NuevoBienesSF()
        {
            InitializeComponent();
        }

        private void NuevoBienesSF_Load(object sender, EventArgs e)
        {
            llenaretiqueta();
            Clases.Empleados.CBNombreSB(CBEmpleado);
            Clases.Articulos.CBBuscarArticulo(CBArticulo);
            Clases.Bienes.CBMarca(CBMarca);
            Clases.Bienes.CBProveedor(CBProveedor);
        }

        private void llenaretiqueta()
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT MAX(ETIQUETA)+1 as etiqueta FROM BIENES", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TBEtiqueta.Text = dr["etiqueta"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void CBEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select departamento from empleados where Nombre='" + CBEmpleado.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LBDepartamento.Text = dr["departamento"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void CBArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select Familia.Descripcion as familia from CatArticulos,Familia where Familia.Id=CatArticulos.IdFamilia and CatArticulos.Descripcion='" + CBArticulo.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LBFamilia.Text = dr["familia"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void CBProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cn = new SqlConnection(Clases.Variables.scon);
            try
            {
                cn.Open();
                cmd = new SqlCommand("select direccion,rfc from proveedores where Nombre='" + CBProveedor.SelectedItem + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LBDomicilio.Text = dr["direccion"].ToString();
                    LBRFC.Text = dr["rfc"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar :" + ex.ToString());
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (CBArticulo.SelectedIndex >= 0 && CBConservacion.SelectedIndex >= 0 && CBEmpleado.SelectedIndex >= 0 && CBProveedor.SelectedIndex >= 0 && CBMarca.SelectedIndex >= 0 && TBNoOrden.Text.Length > 0 && TBPrecio.Text.Length > 0)
            {
                int etiqueta = int.Parse(TBEtiqueta.Text);
                var con = 0;
                if (CHConsumible.Checked == true)
                    con = 1;
                string ConnString = Clases.Variables.scon;
                for (int x = 0; x < Cantidad.Value; x++)
                {
                    string SqlString = "Insert Into bienes (Etiqueta,NoOrden,Mes,AOrden,NoFactura,Precio,iva,total,TipoIva," +
                    "IdArticulo,Observacion,NoEmpleado,IdProveedor,FechaCompra,Baja,IdMarca,Serie,Modelo,Color,Bloqueado," +
                    "Consumible,Estado,Creador) values (" + etiqueta + "," + TBNoOrden.Text + ",9,2013,''," +
                    "" + TBPrecio.Text + ",0.00," + TBPrecio.Text + ",2,(select id from CatArticulos where descripcion='"
                    + CBArticulo.SelectedItem + "'),'" + TBObservaciones.Text + "',(select NoEmp from empleados where nombre='"
                    + CBEmpleado.SelectedItem + "'),(select id from proveedores where nombre='" + CBProveedor.SelectedItem + "')" +
                    ",(convert(datetime,'" + TimeFecha.Text + "')),0,(select top 1 id from marca where descripcion='" + CBMarca.SelectedItem + "')," +
                    "'" + TBSerie.Text + "','" + TBModelo.Text + "','" + TBColor.Text + "',0," + con + ",'" + CBConservacion.SelectedItem + "','"
                    + Clases.Variables.Usuario + "')";
                    Clases.Inserciones.BEjecucion(SqlString);
                    etiqueta = etiqueta + 1;
                }
                if (Clases.Variables.ErrorB == false)
                {
                    if (Cantidad.Value == 1)
                        MessageBox.Show("Bien agregado correctamente.");
                    else
                        MessageBox.Show("Bienes agregados correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("No fue posible agregar los bienes.");
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los espacios que contengan un (*)");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TBPrecio_Leave(object sender, EventArgs e)
        {
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(TBPrecio.Text, out numero);
            if ((!(bln)) && TBPrecio.Text.Length > 0)
            {
                TBPrecio.Clear();
                MessageBox.Show("Precio Incorrecto");
            }
        }

        private void TBNoOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NArt_Click(object sender, EventArgs e)
        {
            Catalogos.Articulos.Nuevo nuevo = new Catalogos.Articulos.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.Articulos.CBBuscarArticulo(CBArticulo);
        }

        private void NPor_Click(object sender, EventArgs e)
        {
            Catalogos.Proveedores.Nuevo nuevo = new Catalogos.Proveedores.Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.Bienes.CBProveedor(CBProveedor);
        }

        private void GuardareImprmir_Click_1(object sender, EventArgs e)
        {
            if (CBArticulo.SelectedIndex >= 0 && CBConservacion.SelectedIndex >= 0 && CBEmpleado.SelectedIndex >= 0 && CBProveedor.SelectedIndex >= 0 && CBMarca.SelectedIndex >= 0 && TBNoOrden.Text.Length > 0 && TBPrecio.Text.Length > 0)
            {
                int etiqueta = int.Parse(TBEtiqueta.Text);
                var con = 0;
                if (CHConsumible.Checked == true)
                    con = 1;
                string ConnString = Clases.Variables.scon;
                for (int x = 0; x < Cantidad.Value; x++)
                {
                    string SqlString = "Insert Into bienes (Etiqueta,NoOrden,Mes,AOrden,NoFactura,Precio,iva,total,TipoIva," +
                    "IdArticulo,Observacion,NoEmpleado,IdProveedor,FechaCompra,Baja,IdMarca,Serie,Modelo,Color,Bloqueado," +
                    "Consumible,Estado,Creador) values (" + etiqueta + "," + TBNoOrden.Text + ",9,2013,''," +
                    "" + TBPrecio.Text + ",0.00," + TBPrecio.Text + ",2,(select id from CatArticulos where descripcion='"
                    + CBArticulo.SelectedItem + "'),'" + TBObservaciones.Text + "',(select NoEmp from empleados where nombre='"
                    + CBEmpleado.SelectedItem + "'),(select id from proveedores where nombre='" + CBProveedor.SelectedItem + "')" +
                    ",(convert(datetime,'" + TimeFecha.Text + "')),0,(select top 1 id from marca where descripcion='" + CBMarca.SelectedItem + "')," +
                    "'" + TBSerie.Text + "','" + TBModelo.Text + "','" + TBColor.Text + "',0," + con + ",'" + CBConservacion.SelectedItem + "','"
                    + Clases.Variables.Usuario + "')";
                    Clases.Inserciones.BEjecucion(SqlString);
                    etiqueta = etiqueta + 1;
                }
                if (Clases.Variables.ErrorB == false)
                {
                    if (Cantidad.Value == 1)
                        MessageBox.Show("Bien agregado correctamente.");
                    else
                        MessageBox.Show("Bienes agregados correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No fue posible agregar los bienes.");
                }
                Clases.Variables.ImprimirBienesOrdenCompraSF = TBNoOrden.Text;
                Clases.Variables.ImprimirBienesTotalSF = TBPrecio.Text;
                Clases.Variables.ImprimirBienesDepartamentoSF = LBDepartamento.Text;
                Clases.Variables.ImprimirBienesDescripcionArticuloSF = CBArticulo.Text;
                Clases.Variables.ImprimirBienesEmpleadoSF = CBEmpleado.Text;
                Clases.Variables.ImprimirBienesFamiliaSF = LBFamilia.Text;
                Clases.Variables.ImprimirBienesSerieSF = TBSerie.Text;
                Clases.Variables.ImprimirBienesObservacionSF = TBObservaciones.Text;
                Clases.Variables.ImprimirBienesCantidadSF = Cantidad.Value.ToString();
                int EtiquetaInicial = int.Parse(TBEtiqueta.Text);
                decimal EtiquetaFinal = EtiquetaInicial + Cantidad.Value-1;
                if (Cantidad.Value == 1)
                {
                    Clases.Variables.ImprimirBienesEtiquetaSF = EtiquetaInicial.ToString();
                }
                else
                {
                    Clases.Variables.ImprimirBienesEtiquetaSF = EtiquetaInicial.ToString() + " a " + EtiquetaFinal.ToString();
                }
                Activo.BienesSF.ImprimirBienesSF reporteImprimirBienesSF = new ImprimirBienesSF();
                reporteImprimirBienesSF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos obligatorios (*)");
            }
            
        }
    }
}
