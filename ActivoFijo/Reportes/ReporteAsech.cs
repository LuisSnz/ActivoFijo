using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Reportes
{
    public partial class ReporteAsech : Form
    {
        public ReporteAsech()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaAsech= "SELECT 'N/A' AS NoResguardo, bienes.Etiqueta as NoInventario, Familia.Descripcion as SubCuenta," +
                "CatArticulos.Descripcion AS Descricion,empleados.Departamento as Ubicacion, marca.Descripcion as Expr1,bienes.Modelo,bienes.Serie," +
                "bienes.NoFactura,bienes.FechaCompra,bienes.Precio,bienes.total as Contabilidad,'RECURSOS PROPIOS' as Origen,'ALTA' as alta, " +
                "FechaCompra as FechaMov, bienes.Estado,Mes,AOrden,'FALSE' AS Consumible FROM bienes INNER JOIN empleados" +
                " ON bienes.NoEmpleado = empleados.NoEmp INNER JOIN CatArticulos ON bienes.IdArticulo = CatArticulos.Id LEFT OUTER JOIN Familia" +
                " ON CatArticulos.IdFamilia = Familia.Id LEFT OUTER JOIN marca on bienes.IdMarca = marca.Id where FechaCompra " +
                "BETWEEN '"+Inicio.Text+"' AND '"+Fin.Text+"'";
            Clases.Excel.DSExcel(Clases.LLenadoGrids.GenerarDataSet(Clases.Variables.ConsultaAsech, "bienes"));
        }
    }
}
