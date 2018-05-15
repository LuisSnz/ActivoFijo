namespace ActivoFijo
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Catalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.Areas = new System.Windows.Forms.ToolStripMenuItem();
            this.SubDirecciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Departamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.Vehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.Marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.Familias = new System.Windows.Forms.ToolStripMenuItem();
            this.Activo = new System.Windows.Forms.ToolStripMenuItem();
            this.Bienes = new System.Windows.Forms.ToolStripMenuItem();
            this.BienesSF = new System.Windows.Forms.ToolStripMenuItem();
            this.BienesBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirEtiquetas = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Historico = new System.Windows.Forms.ToolStripMenuItem();
            this.ValorBienes = new System.Windows.Forms.ToolStripMenuItem();
            this.Configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurarImpresora = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelBase = new System.Windows.Forms.Panel();
            this.LogoLocal = new System.Windows.Forms.PictureBox();
            this.LogoEstatal = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEstatal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Catalogos,
            this.Activo,
            this.Reportes,
            this.Configuracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Catalogos
            // 
            this.Catalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Areas,
            this.SubDirecciones,
            this.Departamentos,
            this.Empleados,
            this.Vehiculos,
            this.Proveedores,
            this.Articulos,
            this.Marcas,
            this.Familias});
            this.Catalogos.Image = global::ActivoFijo.Properties.Resources.catalogo;
            this.Catalogos.Name = "Catalogos";
            this.Catalogos.Size = new System.Drawing.Size(94, 21);
            this.Catalogos.Text = "Catalogos";
            // 
            // Areas
            // 
            this.Areas.Image = global::ActivoFijo.Properties.Resources.areas;
            this.Areas.Name = "Areas";
            this.Areas.Size = new System.Drawing.Size(197, 22);
            this.Areas.Text = "Areas o Direcciones";
            this.Areas.Click += new System.EventHandler(this.Areas_Click);
            // 
            // SubDirecciones
            // 
            this.SubDirecciones.Image = global::ActivoFijo.Properties.Resources.subdirecciones;
            this.SubDirecciones.Name = "SubDirecciones";
            this.SubDirecciones.Size = new System.Drawing.Size(197, 22);
            this.SubDirecciones.Text = "SubDirecciones";
            this.SubDirecciones.Click += new System.EventHandler(this.SubDirecciones_Click);
            // 
            // Departamentos
            // 
            this.Departamentos.Image = global::ActivoFijo.Properties.Resources.departamentos;
            this.Departamentos.Name = "Departamentos";
            this.Departamentos.Size = new System.Drawing.Size(197, 22);
            this.Departamentos.Text = "Departamentos ";
            this.Departamentos.Click += new System.EventHandler(this.Departamentos_Click);
            // 
            // Empleados
            // 
            this.Empleados.Image = global::ActivoFijo.Properties.Resources.empleados;
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(197, 22);
            this.Empleados.Text = "Empleados";
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // Vehiculos
            // 
            this.Vehiculos.Image = global::ActivoFijo.Properties.Resources.vehiculo;
            this.Vehiculos.Name = "Vehiculos";
            this.Vehiculos.Size = new System.Drawing.Size(197, 22);
            this.Vehiculos.Text = "Vehiculos";
            this.Vehiculos.Click += new System.EventHandler(this.Vehiculos_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.Image = global::ActivoFijo.Properties.Resources.proveedores;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(197, 22);
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // Articulos
            // 
            this.Articulos.Image = global::ActivoFijo.Properties.Resources.articulos;
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(197, 22);
            this.Articulos.Text = "Articulos";
            this.Articulos.Click += new System.EventHandler(this.Articulos_Click);
            // 
            // Marcas
            // 
            this.Marcas.Image = global::ActivoFijo.Properties.Resources._123;
            this.Marcas.Name = "Marcas";
            this.Marcas.Size = new System.Drawing.Size(197, 22);
            this.Marcas.Text = "Marcas";
            this.Marcas.Click += new System.EventHandler(this.Marcas_Click);
            // 
            // Familias
            // 
            this.Familias.Image = global::ActivoFijo.Properties.Resources._1234;
            this.Familias.Name = "Familias";
            this.Familias.Size = new System.Drawing.Size(197, 22);
            this.Familias.Text = "Familias";
            this.Familias.Click += new System.EventHandler(this.Familias_Click);
            // 
            // Activo
            // 
            this.Activo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bienes,
            this.BienesSF,
            this.BienesBaja,
            this.ImprimirEtiquetas});
            this.Activo.Image = global::ActivoFijo.Properties.Resources.casa;
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(75, 21);
            this.Activo.Text = "Activo";
            // 
            // Bienes
            // 
            this.Bienes.Image = global::ActivoFijo.Properties.Resources.bienes;
            this.Bienes.Name = "Bienes";
            this.Bienes.Size = new System.Drawing.Size(200, 22);
            this.Bienes.Text = "Bienes";
            this.Bienes.Click += new System.EventHandler(this.Bienes_Click);
            // 
            // BienesSF
            // 
            this.BienesSF.Image = global::ActivoFijo.Properties.Resources.bienesSF;
            this.BienesSF.Name = "BienesSF";
            this.BienesSF.Size = new System.Drawing.Size(200, 22);
            this.BienesSF.Text = "Bienes sin Factura";
            this.BienesSF.Click += new System.EventHandler(this.BienesSF_Click);
            // 
            // BienesBaja
            // 
            this.BienesBaja.Image = global::ActivoFijo.Properties.Resources.rechazado;
            this.BienesBaja.Name = "BienesBaja";
            this.BienesBaja.Size = new System.Drawing.Size(200, 22);
            this.BienesBaja.Text = "Bienes dados de baja";
            this.BienesBaja.Click += new System.EventHandler(this.BienesBaja_Click);
            // 
            // ImprimirEtiquetas
            // 
            this.ImprimirEtiquetas.Image = global::ActivoFijo.Properties.Resources.codigobarras;
            this.ImprimirEtiquetas.Name = "ImprimirEtiquetas";
            this.ImprimirEtiquetas.Size = new System.Drawing.Size(200, 22);
            this.ImprimirEtiquetas.Text = "Imprimir Etiquetas";
            this.ImprimirEtiquetas.Click += new System.EventHandler(this.ImprimirEtiquetas_Click);
            // 
            // Reportes
            // 
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Historico,
            this.ValorBienes});
            this.Reportes.Image = global::ActivoFijo.Properties.Resources.catalogo;
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(89, 21);
            this.Reportes.Text = "Reportes";
            // 
            // Historico
            // 
            this.Historico.Image = global::ActivoFijo.Properties.Resources.h;
            this.Historico.Name = "Historico";
            this.Historico.Size = new System.Drawing.Size(181, 22);
            this.Historico.Text = "Historico del Bien";
            this.Historico.Click += new System.EventHandler(this.Historico_Click);
            // 
            // ValorBienes
            // 
            this.ValorBienes.Image = global::ActivoFijo.Properties.Resources.Dinero;
            this.ValorBienes.Name = "ValorBienes";
            this.ValorBienes.Size = new System.Drawing.Size(181, 22);
            this.ValorBienes.Text = "Valor en Bienes";
            this.ValorBienes.Click += new System.EventHandler(this.ValorBienes_Click);
            // 
            // Configuracion
            // 
            this.Configuracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigurarImpresora});
            this.Configuracion.Image = global::ActivoFijo.Properties.Resources.configuracion;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Size = new System.Drawing.Size(118, 21);
            this.Configuracion.Text = "Configuración";
            // 
            // ConfigurarImpresora
            // 
            this.ConfigurarImpresora.Image = global::ActivoFijo.Properties.Resources.impresora;
            this.ConfigurarImpresora.Name = "ConfigurarImpresora";
            this.ConfigurarImpresora.Size = new System.Drawing.Size(212, 22);
            this.ConfigurarImpresora.Text = "Impresora de Etiquetas";
            this.ConfigurarImpresora.Click += new System.EventHandler(this.ConfigurarImpresora_Click);
            // 
            // PanelBase
            // 
            this.PanelBase.BackColor = System.Drawing.Color.Transparent;
            this.PanelBase.Location = new System.Drawing.Point(0, 25);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelBase.Size = new System.Drawing.Size(1377, 681);
            this.PanelBase.TabIndex = 2;
            // 
            // LogoLocal
            // 
            this.LogoLocal.Image = global::ActivoFijo.Properties.Resources.logo_pirata;
            this.LogoLocal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoLocal.Location = new System.Drawing.Point(1095, 84);
            this.LogoLocal.Name = "LogoLocal";
            this.LogoLocal.Size = new System.Drawing.Size(231, 273);
            this.LogoLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoLocal.TabIndex = 6;
            this.LogoLocal.TabStop = false;
            // 
            // LogoEstatal
            // 
            this.LogoEstatal.Image = global::ActivoFijo.Properties.Resources._7da9c795_1ecb_4dd7_ba41_298ad0ca7a56;
            this.LogoEstatal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoEstatal.Location = new System.Drawing.Point(1031, 381);
            this.LogoEstatal.Name = "LogoEstatal";
            this.LogoEstatal.Size = new System.Drawing.Size(346, 273);
            this.LogoEstatal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoEstatal.TabIndex = 5;
            this.LogoEstatal.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 745);
            this.Controls.Add(this.LogoLocal);
            this.Controls.Add(this.LogoEstatal);
            this.Controls.Add(this.PanelBase);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Inicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Activo Fijo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEstatal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Catalogos;
        private System.Windows.Forms.ToolStripMenuItem Areas;
        private System.Windows.Forms.ToolStripMenuItem SubDirecciones;
        private System.Windows.Forms.ToolStripMenuItem Departamentos;
        private System.Windows.Forms.ToolStripMenuItem Empleados;
        private System.Windows.Forms.ToolStripMenuItem Vehiculos;
        private System.Windows.Forms.ToolStripMenuItem Proveedores;
        private System.Windows.Forms.ToolStripMenuItem Articulos;
        private System.Windows.Forms.ToolStripMenuItem Marcas;
        private System.Windows.Forms.ToolStripMenuItem Familias;
        private System.Windows.Forms.ToolStripMenuItem Activo;
        private System.Windows.Forms.ToolStripMenuItem Bienes;
        private System.Windows.Forms.ToolStripMenuItem BienesSF;
        private System.Windows.Forms.ToolStripMenuItem ImprimirEtiquetas;
        private System.Windows.Forms.ToolStripMenuItem BienesBaja;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem Historico;
        private System.Windows.Forms.ToolStripMenuItem ValorBienes;
        private System.Windows.Forms.ToolStripMenuItem Configuracion;
        private System.Windows.Forms.ToolStripMenuItem ConfigurarImpresora;
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.PictureBox LogoLocal;
        private System.Windows.Forms.PictureBox LogoEstatal;
    }
}

