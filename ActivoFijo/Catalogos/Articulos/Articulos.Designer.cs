namespace ActivoFijo.Catalogos.Articulos
{
    partial class Articulos
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
            this.Borrar = new System.Windows.Forms.ToolStripButton();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.GVCatArticulos = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCatArticulos)).BeginInit();
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
            this.Borrar,
            this.Buscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 45);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Nuevo
            // 
            this.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nuevo.Image = global::ActivoFijo.Properties.Resources.nuevo;
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(44, 42);
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Modificar
            // 
            this.Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Modificar.Image = global::ActivoFijo.Properties.Resources.modificar_;
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(44, 42);
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Borrar
            // 
            this.Borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Borrar.Image = global::ActivoFijo.Properties.Resources.eliminar_;
            this.Borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(44, 42);
            this.Borrar.Text = "Eliminar";
            // 
            // Buscar
            // 
            this.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Buscar.Image = global::ActivoFijo.Properties.Resources.buscar;
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(44, 42);
            this.Buscar.Text = "Buscar";
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // GVCatArticulos
            // 
            this.GVCatArticulos.AllowUserToAddRows = false;
            this.GVCatArticulos.AllowUserToDeleteRows = false;
            this.GVCatArticulos.AllowUserToOrderColumns = true;
            this.GVCatArticulos.AllowUserToResizeColumns = false;
            this.GVCatArticulos.AllowUserToResizeRows = false;
            this.GVCatArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GVCatArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GVCatArticulos.BackgroundColor = System.Drawing.Color.White;
            this.GVCatArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVCatArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCatArticulos.Location = new System.Drawing.Point(12, 48);
            this.GVCatArticulos.Name = "GVCatArticulos";
            this.GVCatArticulos.ReadOnly = true;
            this.GVCatArticulos.Size = new System.Drawing.Size(840, 600);
            this.GVCatArticulos.TabIndex = 4;
            this.GVCatArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCatArticulos_CellDoubleClick);
            this.GVCatArticulos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCatArticulos_CellEnter);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GVCatArticulos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCatArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripButton Borrar;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.DataGridView GVCatArticulos;
    }
}