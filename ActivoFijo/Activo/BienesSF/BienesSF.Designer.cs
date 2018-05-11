namespace ActivoFijo.Activo.BienesSF
{
    partial class BienesSF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.DarDeBaja = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Excel = new System.Windows.Forms.ToolStripButton();
            this.Etiqueta = new System.Windows.Forms.ToolStripButton();
            this.Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CambioPorEmpleado = new System.Windows.Forms.ToolStripButton();
            this.CambioDeBien = new System.Windows.Forms.ToolStripButton();
            this.GridBienesSF = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBienesSF)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Modificar,
            this.DarDeBaja,
            this.toolStripSeparator1,
            this.Buscar,
            this.toolStripSeparator2,
            this.Excel,
            this.Etiqueta,
            this.Imprimir,
            this.toolStripSeparator3,
            this.CambioPorEmpleado,
            this.CambioDeBien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 45);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Nuevo
            // 
            this.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nuevo.Image = global::ActivoFijo.Properties.Resources.nuevo;
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(44, 42);
            this.Nuevo.Text = "toolStripButton1";
            this.Nuevo.ToolTipText = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Modificar
            // 
            this.Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Modificar.Image = global::ActivoFijo.Properties.Resources.modificar_;
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(44, 42);
            this.Modificar.Text = "toolStripButton3";
            this.Modificar.ToolTipText = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // DarDeBaja
            // 
            this.DarDeBaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DarDeBaja.Image = global::ActivoFijo.Properties.Resources.eliminar_;
            this.DarDeBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DarDeBaja.Name = "DarDeBaja";
            this.DarDeBaja.Size = new System.Drawing.Size(44, 42);
            this.DarDeBaja.Text = "toolStripButton4";
            this.DarDeBaja.ToolTipText = "Dar de Baja";
            this.DarDeBaja.Click += new System.EventHandler(this.DarDeBaja_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // Buscar
            // 
            this.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Buscar.Image = global::ActivoFijo.Properties.Resources.buscar;
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(44, 42);
            this.Buscar.Text = "toolStripButton5";
            this.Buscar.ToolTipText = "Buscar";
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // Excel
            // 
            this.Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Excel.Image = global::ActivoFijo.Properties.Resources.excel;
            this.Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(44, 42);
            this.Excel.Text = "toolStripButton6";
            this.Excel.ToolTipText = "Exportar a Excel";
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // Etiqueta
            // 
            this.Etiqueta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Etiqueta.Image = global::ActivoFijo.Properties.Resources.codigobarras;
            this.Etiqueta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(44, 42);
            this.Etiqueta.Text = "toolStripButton7";
            this.Etiqueta.ToolTipText = "Imprimir Etiqueta";
            this.Etiqueta.Click += new System.EventHandler(this.Etiqueta_Click);
            // 
            // Imprimir
            // 
            this.Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Imprimir.Image = global::ActivoFijo.Properties.Resources.impresora;
            this.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(44, 42);
            this.Imprimir.Text = "toolStripButton8";
            this.Imprimir.ToolTipText = "Imprimir";
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // CambioPorEmpleado
            // 
            this.CambioPorEmpleado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CambioPorEmpleado.Image = global::ActivoFijo.Properties.Resources.cambiobienes;
            this.CambioPorEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CambioPorEmpleado.Name = "CambioPorEmpleado";
            this.CambioPorEmpleado.Size = new System.Drawing.Size(44, 42);
            this.CambioPorEmpleado.Text = "toolStripButton1";
            this.CambioPorEmpleado.ToolTipText = "Cambio de Bienes por Empleado";
            this.CambioPorEmpleado.Click += new System.EventHandler(this.CambioPorEmpleado_Click);
            // 
            // CambioDeBien
            // 
            this.CambioDeBien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CambioDeBien.Image = global::ActivoFijo.Properties.Resources.Imagen1;
            this.CambioDeBien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CambioDeBien.Name = "CambioDeBien";
            this.CambioDeBien.Size = new System.Drawing.Size(44, 42);
            this.CambioDeBien.Text = "toolStripButton2";
            this.CambioDeBien.ToolTipText = "Cambiar Bien";
            this.CambioDeBien.Click += new System.EventHandler(this.CambioDeBien_Click);
            // 
            // GridBienesSF
            // 
            this.GridBienesSF.AllowUserToAddRows = false;
            this.GridBienesSF.AllowUserToDeleteRows = false;
            this.GridBienesSF.AllowUserToOrderColumns = true;
            this.GridBienesSF.AllowUserToResizeColumns = false;
            this.GridBienesSF.AllowUserToResizeRows = false;
            this.GridBienesSF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridBienesSF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridBienesSF.BackgroundColor = System.Drawing.Color.White;
            this.GridBienesSF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridBienesSF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBienesSF.Location = new System.Drawing.Point(12, 48);
            this.GridBienesSF.MultiSelect = false;
            this.GridBienesSF.Name = "GridBienesSF";
            this.GridBienesSF.ReadOnly = true;
            this.GridBienesSF.Size = new System.Drawing.Size(950, 600);
            this.GridBienesSF.TabIndex = 7;
            this.GridBienesSF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBienesSF_CellDoubleClick);
            this.GridBienesSF.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBienesSF_CellEnter);
            // 
            // BienesSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridBienesSF);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BienesSF";
            this.Text = "BienesSF";
            this.Load += new System.EventHandler(this.BienesSF_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBienesSF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripButton DarDeBaja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Excel;
        private System.Windows.Forms.ToolStripButton Etiqueta;
        private System.Windows.Forms.ToolStripButton Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton CambioPorEmpleado;
        private System.Windows.Forms.ToolStripButton CambioDeBien;
        private System.Windows.Forms.DataGridView GridBienesSF;
    }
}