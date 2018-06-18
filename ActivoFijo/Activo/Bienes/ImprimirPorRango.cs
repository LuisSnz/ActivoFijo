using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace ActivoFijo.Activo.Bienes
{
    public partial class ImprimirPorRango : Form
    {
        public ImprimirPorRango()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            ReporteBienes reporteBienes = new ReporteBienes();
            reporteBienes.ShowDialog();
        }
    }
}
