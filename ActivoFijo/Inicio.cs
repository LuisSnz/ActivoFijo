using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void formularios(object hijo)
        {
            if (this.PanelBase.Controls.Count > 0)
            {
                this.PanelBase.Controls.RemoveAt(0);
            }
                Form hi = hijo as Form;
                hi.TopLevel = false;
                hi.FormBorderStyle = FormBorderStyle.None;
                hi.Dock = DockStyle.Fill;
                this.PanelBase.Controls.Add(hi);
                this.PanelBase.Tag = hi;
                hi.Show();
                LogoLocal.BringToFront();
                LogoEstatal.BringToFront();
        }
        private void Areas_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Areas.Areas());
            this.Text = "Sistema de activo Fijo - Areas";
        }

        private void SubDirecciones_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.SubDirecciones.SubDirecciones());
            this.Text = "Sistema de activo Fijo - SubDireccion";
        }

        private void Departamentos_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Departamentos.Departamentos());
            this.Text = "Sistema de activo Fijo - Departamentos";
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Empleados.Empleados());
            this.Text = "Sistema de activo Fijo - Empleados";
        }

        private void Vehiculos_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Vehiculos.Vehiculos());
            this.Text = "Sistema de activo Fijo - Vehiculos";
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Proveedores.Proveedores());
            this.Text = "Sistema de activo Fijo - Proveedores";
        }

        private void Articulos_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Articulos.Articulos());
            this.Text = "Sistema de activo Fijo - Articulos";
        }

        private void Marcas_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Marcas.Marcas());
            this.Text = "Sistema de activo Fijo - Marcas";
        }

        private void Familias_Click(object sender, EventArgs e)
        {
            formularios(new Catalogos.Familias.Familias());
            this.Text = "Sistema de activo Fijo - Familias";
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            PanelBase.Width = this.Width;
            PanelBase.Height = this.Height - 70;
            Clases.Variables.GridHeight = this.Height - 130;
            Clases.Variables.GridWidth = this.Width - (this.Width / 3);
            LogoLocal.Location = new Point(this.Width - (this.Width / 5), 80);
            LogoLocal.Height = this.Height / 3;
            LogoLocal.Width = this.Width / 6;
            LogoEstatal.Location = new Point(this.Width - (this.Width / 4), this.Height - (this.Height / 2));
            LogoEstatal.Height = this.Height / 3;
            LogoEstatal.Width = this.Width / 4;
        }

        private void Bienes_Click(object sender, EventArgs e)
        {
            formularios(new Activo.Bienes.Bienes());
            this.Text = "Sistema de activo Fijo - Bienes";
        }

        private void BienesSF_Click(object sender, EventArgs e)
        {
            formularios(new Activo.BienesSF.BienesSF());
            this.Text = "Sistema de activo Fijo - Bienes sin Factura";
        }

        private void BienesBaja_Click(object sender, EventArgs e)
        {
            this.Text = "Sistema de activo Fijo - Bienes dados de Baja";
            formularios(new Activo.BienesBaja.BienesDadosDeBaja());
        }

        private void ImprimirEtiquetas_Click(object sender, EventArgs e)
        {
            Activo.ImprimirEtiquetas imprimir = new Activo.ImprimirEtiquetas();
            imprimir.ShowDialog();
        }

        private void Historico_Click(object sender, EventArgs e)
        {
            Reportes.HistoricoDeBienes historico = new Reportes.HistoricoDeBienes();
            historico.ShowDialog();
        }

        private void ValorBienes_Click(object sender, EventArgs e)
        {
            formularios(new Reportes.ValorBienes.ValorEnBienes());
            this.Text = "Sistema de activo Fijo - Valor en Bienes";
        }
            
        private void ConfigurarImpresora_Click(object sender, EventArgs e)
        {
            Auxiliares.ConfImpresora confImpresora = new Auxiliares.ConfImpresora();
            confImpresora.ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios.NuevoUsuario Nuevo = new Usuarios.NuevoUsuario();
            Nuevo.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios.Contraseña cambio = new Usuarios.Contraseña();
            cambio.ShowDialog();
        }

        private void conexionDeBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auxiliares.ConexionBD conexionBD = new Auxiliares.ConexionBD();
            conexionBD.ShowDialog();
        }
    }
}
