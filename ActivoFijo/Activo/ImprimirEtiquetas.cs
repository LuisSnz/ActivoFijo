using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Activo
{
    public partial class ImprimirEtiquetas : Form
    {
        public ImprimirEtiquetas()
        {
            InitializeComponent();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Clases.Etiquetas.llamarVariableEtiqueta();
            if (Clases.Variables.ConfImpresora == null)
                MessageBox.Show("Impresora no asignada, porfavor dirijase a (Configuracion/Impresora de etiqueta) y especifique el nombre de la impresora");
            else
                Clases.Etiquetas.ImprimirEtiquetas(minimo.Value.ToString(), maximo.Value.ToString());
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
