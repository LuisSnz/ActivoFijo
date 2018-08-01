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
    public partial class HistoricoDeBienes : Form
    {
        public HistoricoDeBienes()
        {
            InitializeComponent();
        }

        private void Etiqueta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "Select HistoricoBienes.Etiqueta, empleados.Nombre, HistoricoBienes.FechaCambio" +
                " from HistoricoBienes inner join empleados on HistoricoBienes.NoEmpleado=empleados.NoEmp where HistoricoBienes.Etiqueta=" + Etiqueta.SelectedItem.ToString();
            Clases.LLenadoGrids.llenarGrid(GridHistorico, Clases.Variables.ConsultaBuscar, "HistoricoBienes");
        }

        private void HistoricoDeBienes_Load(object sender, EventArgs e)
        {
            Clases.Bienes.CBEtiquetaHistorico(Etiqueta);
            Clases.Variables.ConsultaBuscar = "Select HistoricoBienes.Etiqueta, empleados.Nombre, HistoricoBienes.FechaCambio" +
                " from HistoricoBienes inner join empleados on HistoricoBienes.NoEmpleado=empleados.NoEmp";
            Clases.LLenadoGrids.llenarGrid(GridHistorico, Clases.Variables.ConsultaBuscar, "HistoricoBienes");
        }
    }
}
