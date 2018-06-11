using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Vehiculos
{
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            GVVehiculos.Width = Clases.Variables.GridWidth;
            GVVehiculos.Height = Clases.Variables.GridHeight;
            Clases.Variables.ConsultaBuscar = "select Numero,Placas,Modelo,Tipo,Subtipo,Marca,NoSerie,FamiliaVehiculos.Descripcion as Familia,empleados.Nombre as Resguardo,Observacion " +
                "from vehiculo inner join familiavehiculos on FamiliaVehiculos.Id=VEHICULO.Familia left outer join empleados on empleados.NoEmp=Vehiculo.NoEmp";
            Clases.LLenadoGrids.llenarGrid(GVVehiculos, Clases.Variables.ConsultaBuscar, "vVehiculos");
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Catalogos.Vehiculos.ReporteVehiculos reporteVehiculos = new ReporteVehiculos();
            reporteVehiculos.ShowDialog();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            Clases.Excel.GridViewExcel(GVVehiculos);
        }
    }
}
