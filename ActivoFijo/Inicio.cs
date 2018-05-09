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

        }
    }
}
