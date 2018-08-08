namespace ActivoFijo.Reportes.ValorBienes
{
    partial class ValorEnBienes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValorEnBienes));
            this.Total = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCosto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LBTotalBienes = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.Excel = new System.Windows.Forms.ToolStripButton();
            this.Imprimir = new System.Windows.Forms.ToolStripButton();
            this.ImprimirPorFecha = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(126, 546);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 17);
            this.Total.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Buscar,
            this.Excel,
            this.Imprimir,
            this.ImprimirPorFecha});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(590, 45);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 659);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total en bienes :";
            // 
            // GridCosto
            // 
            this.GridCosto.AllowUserToAddRows = false;
            this.GridCosto.AllowUserToDeleteRows = false;
            this.GridCosto.AllowUserToOrderColumns = true;
            this.GridCosto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridCosto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridCosto.BackgroundColor = System.Drawing.Color.White;
            this.GridCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCosto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCosto.Location = new System.Drawing.Point(12, 48);
            this.GridCosto.Name = "GridCosto";
            this.GridCosto.ReadOnly = true;
            this.GridCosto.Size = new System.Drawing.Size(870, 594);
            this.GridCosto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 659);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total de bienes :";
            // 
            // LBTotalBienes
            // 
            this.LBTotalBienes.AutoSize = true;
            this.LBTotalBienes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotalBienes.Location = new System.Drawing.Point(510, 659);
            this.LBTotalBienes.Name = "LBTotalBienes";
            this.LBTotalBienes.Size = new System.Drawing.Size(0, 19);
            this.LBTotalBienes.TabIndex = 11;
            this.LBTotalBienes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = false;
            this.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Buscar.Image = global::ActivoFijo.Properties.Resources.buscar;
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(50, 50);
            this.Buscar.Text = "toolStripButton1";
            this.Buscar.ToolTipText = "Buscar";
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Excel
            // 
            this.Excel.AutoSize = false;
            this.Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Excel.Image = global::ActivoFijo.Properties.Resources.excel;
            this.Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(50, 50);
            this.Excel.Text = "toolStripButton2";
            this.Excel.ToolTipText = "Importar a Excel";
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // Imprimir
            // 
            this.Imprimir.AutoSize = false;
            this.Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Imprimir.Image = global::ActivoFijo.Properties.Resources.impresora;
            this.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(50, 50);
            this.Imprimir.Text = "toolStripButton3";
            this.Imprimir.ToolTipText = "Imprimir Reporte";
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // ImprimirPorFecha
            // 
            this.ImprimirPorFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImprimirPorFecha.Image = global::ActivoFijo.Properties.Resources.calendario;
            this.ImprimirPorFecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImprimirPorFecha.Name = "ImprimirPorFecha";
            this.ImprimirPorFecha.Size = new System.Drawing.Size(44, 42);
            this.ImprimirPorFecha.Text = "ImprimirPorFecha";
            this.ImprimirPorFecha.ToolTipText = "Imprimir por Fecha";
            this.ImprimirPorFecha.Click += new System.EventHandler(this.ImprimirPorFecha_Click);
            // 
            // ValorEnBienes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 687);
            this.Controls.Add(this.LBTotalBienes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCosto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ValorEnBienes";
            this.Text = "Valor En Bienes";
            this.Load += new System.EventHandler(this.ValorEnBienes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.ToolStripButton Excel;
        private System.Windows.Forms.ToolStripButton Imprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBTotalBienes;
        private System.Windows.Forms.ToolStripButton ImprimirPorFecha;
    }
}