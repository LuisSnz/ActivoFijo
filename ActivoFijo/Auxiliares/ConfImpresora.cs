using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ActivoFijo.Auxiliares
{
    public partial class ConfImpresora : Form
    {
        public ConfImpresora()
        {
            InitializeComponent();
        }

        private void ConfImpresora_Load(object sender, EventArgs e)
        {
            String line;
            string ruta = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
            var recurso = "ConfigurarImpresora.txt";
            string archivo = Path.Combine(ruta, recurso);

            if (File.Exists(archivo))
            {
                try
                {
                    StreamReader sr = new StreamReader(archivo);

                    while ((line = sr.ReadLine()) != null)
                    {
                        ConImpresora.Text = line;
                        sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.ToString());
                }
            }
            else
            {
                try
                {
                    FileStream file = File.Create(archivo);
                    file.Close();
                    StreamReader sr = new StreamReader(archivo);

                    while ((line = sr.ReadLine()) != null)
                    {
                        ConImpresora.Text = line;
                        sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.ToString());
                }
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string ruta = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
            var recurso = "ConfigurarImpresora.txt";
            string archivo = Path.Combine(ruta, recurso);
            string texto = ConImpresora.Text;
            StreamWriter writer = new StreamWriter(archivo);
            writer.Write(texto);
            writer.Close();
            MessageBox.Show("Impresora configurada correctamente");
            this.Close();

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
