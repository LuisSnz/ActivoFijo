using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Activo.BienesBaja
{
    public partial class BuscarBienesDDBaja : Form
    {
        public BuscarBienesDDBaja()
        {
            InitializeComponent();
        }

        private void BuscarBienesDDBaja_Load(object sender, EventArgs e)
        {
            Clases.BienesBaja.CBEtiqueta(CBBuscar);
        }

        private void Etiqueta_CheckedChanged(object sender, EventArgs e)
        {
            if (Etiqueta.Checked == true)
                Clases.BienesBaja.CBEtiqueta(CBBuscar);
        }

        private void Articulo_CheckedChanged(object sender, EventArgs e)
        {
            if (Articulo.Checked == true)
                Clases.BienesBaja.CBArticulo(CBBuscar);
        }

        private void Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (Empleado.Checked == true)
                Clases.BienesBaja.CBEmleado(CBBuscar);
        }

        private void Motivo_CheckedChanged(object sender, EventArgs e)
        {
            if (Motivo.Checked == true)
                Clases.BienesBaja.CBMotivo(CBBuscar);
        }

        private void Factura_CheckedChanged(object sender, EventArgs e)
        {
            if (Factura.Checked == true)
                Clases.BienesBaja.CBFactura(CBBuscar);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (Factura.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden,NoFactura, Total, " +
            "Articulo, Observacion, Departamento,Empleado," +
            " FechaCompra, Marca, Serie, Modelo, MotivoBaja, EstatusBaja," +
            "convert( FechaBaja,DATE)  as FechaBaja,ObservacionBaja," +
            "ValorActual, Consumible, Borro FROM BajaBienes where NoFactura LIKE '%" + CBBuscar.Text + "%'";
            else if (Etiqueta.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden,NoFactura, Total, " +
            "Articulo,Observacion, Departamento,Empleado," +
            " FechaCompra, Marca, Serie, Modelo,MotivoBaja, EstatusBaja," +
            "convert(FechaBaja,DATE)  as FechaBaja,ObservacionBaja," +
            "ValorActual, Consumible, Borro FROM BajaBienes where Etiqueta LIKE '%" + CBBuscar.Text + "%'";
            else if (Empleado.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden,NoFactura, Total, " +
            "Articulo,Observacion, Departamento,Empleado," +
            " FechaCompra, Marca, Serie, Modelo, MotivoBaja, EstatusBaja," +
            "convert(FechaBaja,DATE) as FechaBaja,ObservacionBaja," +
            "ValorActual, Consumible, Borro FROM BajaBienes where Empleado LIKE '%" + CBBuscar.Text + "%'";
            else if (Motivo.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden,NoFactura, Total, " +
            "Articulo,Observacion, Departamento,Empleado," +
            " FechaCompra, Marca, Serie, Modelo,MotivoBaja, EstatusBaja," +
            "convert(FechaBaja,DATE)  as FechaBaja,ObservacionBaja," +
            "ValorActual, Consumible, Borro FROM BajaBienes where MotivoBaja LIKE '%" + CBBuscar.Text + "%'";
            else if (Articulo.Checked == true)
                Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden,NoFactura, Total, " +
            "Articulo,Observacion, Departamento,Empleado," +
            " FechaCompra, Marca, Serie, Modelo,MotivoBaja, EstatusBaja," +
            "convert(FechaBaja,DATE)  as FechaBaja,ObservacionBaja," +
            " ValorActual, Consumible, Borro FROM BajaBienes where Articulo LIKE '%" + CBBuscar.Text + "%'";
           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Todo_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "SELECT id, Etiqueta, NoOrden,NoFactura, Total, " +
                "Articulo,  Observacion, Departamento, Empleado," +
                " FechaCompra, Marca, Serie, Modelo,MotivoBaja, EstatusBaja," +
                "convert(FechaBaja,DATE)  as FechaBaja,ObservacionBaja," +
                " ValorActual, Consumible, Borro FROM BajaBienes";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
