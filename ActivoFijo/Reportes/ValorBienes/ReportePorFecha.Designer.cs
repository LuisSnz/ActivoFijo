namespace ActivoFijo.Reportes.ValorBienes
{
    partial class ReportePorFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePorFecha));
            this.Cancelar = new System.Windows.Forms.Button();
            this.Generar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Fin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Inicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConFactura = new System.Windows.Forms.RadioButton();
            this.SinFactura = new System.Windows.Forms.RadioButton();
            this.Ambos = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(237, 136);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(86, 29);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Generar
            // 
            this.Generar.BackColor = System.Drawing.Color.White;
            this.Generar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar.Location = new System.Drawing.Point(87, 136);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(86, 29);
            this.Generar.TabIndex = 6;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = false;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Fin);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(208, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha Final";
            // 
            // Fin
            // 
            this.Fin.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fin.Location = new System.Drawing.Point(12, 24);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(165, 25);
            this.Fin.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Inicio);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha Inicial";
            // 
            // Inicio
            // 
            this.Inicio.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Inicio.Location = new System.Drawing.Point(12, 24);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(165, 25);
            this.Inicio.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.Ambos);
            this.groupBox3.Controls.Add(this.ConFactura);
            this.groupBox3.Controls.Add(this.SinFactura);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 53);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione una Opcion";
            // 
            // ConFactura
            // 
            this.ConFactura.AutoSize = true;
            this.ConFactura.Checked = true;
            this.ConFactura.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConFactura.Location = new System.Drawing.Point(7, 25);
            this.ConFactura.Name = "ConFactura";
            this.ConFactura.Size = new System.Drawing.Size(96, 21);
            this.ConFactura.TabIndex = 4;
            this.ConFactura.TabStop = true;
            this.ConFactura.Text = "Con factura";
            this.ConFactura.UseVisualStyleBackColor = true;
            this.ConFactura.CheckedChanged += new System.EventHandler(this.ConFactura_CheckedChanged);
            // 
            // SinFactura
            // 
            this.SinFactura.AutoSize = true;
            this.SinFactura.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinFactura.Location = new System.Drawing.Point(148, 24);
            this.SinFactura.Name = "SinFactura";
            this.SinFactura.Size = new System.Drawing.Size(90, 21);
            this.SinFactura.TabIndex = 2;
            this.SinFactura.Text = "Sin factura";
            this.SinFactura.UseVisualStyleBackColor = true;
            this.SinFactura.CheckedChanged += new System.EventHandler(this.SinFactura_CheckedChanged);
            // 
            // Ambos
            // 
            this.Ambos.AutoSize = true;
            this.Ambos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ambos.Location = new System.Drawing.Point(310, 24);
            this.Ambos.Name = "Ambos";
            this.Ambos.Size = new System.Drawing.Size(61, 21);
            this.Ambos.TabIndex = 5;
            this.Ambos.Text = "Todos";
            this.Ambos.UseVisualStyleBackColor = true;
            this.Ambos.CheckedChanged += new System.EventHandler(this.Ambos_CheckedChanged);
            // 
            // ReportePorFecha
            // 
            this.AcceptButton = this.Generar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(408, 175);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportePorFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Fecha";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker Fin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Inicio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Ambos;
        private System.Windows.Forms.RadioButton ConFactura;
        private System.Windows.Forms.RadioButton SinFactura;
    }
}