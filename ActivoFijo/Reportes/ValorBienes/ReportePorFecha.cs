using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Reportes.ValorBienes
{
    public partial class ReportePorFecha : Form
    {
        public ReportePorFecha()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generar_Click(object sender, EventArgs e)
        {

        }
    }
}
