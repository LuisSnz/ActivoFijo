namespace ActivoFijo.Catalogos.Empleados
{
    partial class Empleados
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
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.GridEmp = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmp)).BeginInit();
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
            this.Eliminar,
            this.Buscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 45);
            this.toolStrip1.TabIndex = 5;
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
            this.Modificar.Text = "Modificar";
            this.Modificar.ToolTipText = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eliminar.Image = global::ActivoFijo.Properties.Resources.eliminar_;
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(44, 42);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Buscar
            // 
            this.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Buscar.Image = global::ActivoFijo.Properties.Resources.buscar;
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(44, 42);
            this.Buscar.Text = "Buscar";
            this.Buscar.ToolTipText = "Buscar";
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // GridEmp
            // 
            this.GridEmp.AllowUserToAddRows = false;
            this.GridEmp.AllowUserToDeleteRows = false;
            this.GridEmp.AllowUserToOrderColumns = true;
            this.GridEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridEmp.BackgroundColor = System.Drawing.Color.White;
            this.GridEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmp.Location = new System.Drawing.Point(12, 48);
            this.GridEmp.MultiSelect = false;
            this.GridEmp.Name = "GridEmp";
            this.GridEmp.ReadOnly = true;
            this.GridEmp.Size = new System.Drawing.Size(926, 600);
            this.GridEmp.TabIndex = 6;
            this.GridEmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmp_CellDoubleClick);
            this.GridEmp.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmp_CellEnter);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridEmp);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.DataGridView GridEmp;
    }
}