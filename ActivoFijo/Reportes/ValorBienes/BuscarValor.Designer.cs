namespace ActivoFijo.Reportes.ValorBienes
{
    partial class BuscarValor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarValor));
            this.Todo = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Departamento = new System.Windows.Forms.RadioButton();
            this.CBBuscar = new System.Windows.Forms.ComboBox();
            this.Empleado = new System.Windows.Forms.RadioButton();
            this.Articulo = new System.Windows.Forms.RadioButton();
            this.Familia = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConFactura = new System.Windows.Forms.RadioButton();
            this.SinFactura = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Todo
            // 
            this.Todo.BackColor = System.Drawing.Color.White;
            this.Todo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todo.Location = new System.Drawing.Point(119, 207);
            this.Todo.Name = "Todo";
            this.Todo.Size = new System.Drawing.Size(97, 35);
            this.Todo.TabIndex = 14;
            this.Todo.Text = "Mostrar Todo";
            this.Todo.UseVisualStyleBackColor = false;
            this.Todo.Click += new System.EventHandler(this.Todo_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(228, 207);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(97, 35);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.White;
            this.Aceptar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(12, 207);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(97, 35);
            this.Aceptar.TabIndex = 12;
            this.Aceptar.Text = "Buscar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.Departamento);
            this.groupBox1.Controls.Add(this.CBBuscar);
            this.groupBox1.Controls.Add(this.Empleado);
            this.groupBox1.Controls.Add(this.Articulo);
            this.groupBox1.Controls.Add(this.Familia);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un filtro";
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departamento.Location = new System.Drawing.Point(178, 61);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(110, 21);
            this.Departamento.TabIndex = 6;
            this.Departamento.Text = "Departamento";
            this.Departamento.UseVisualStyleBackColor = true;
            this.Departamento.CheckedChanged += new System.EventHandler(this.Departamento_CheckedChanged);
            // 
            // CBBuscar
            // 
            this.CBBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Location = new System.Drawing.Point(6, 91);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(300, 25);
            this.CBBuscar.TabIndex = 5;
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Checked = true;
            this.Empleado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.Location = new System.Drawing.Point(7, 25);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(84, 21);
            this.Empleado.TabIndex = 4;
            this.Empleado.TabStop = true;
            this.Empleado.Text = "Empleado";
            this.Empleado.UseVisualStyleBackColor = true;
            this.Empleado.CheckedChanged += new System.EventHandler(this.Empleado_CheckedChanged);
            // 
            // Articulo
            // 
            this.Articulo.AutoSize = true;
            this.Articulo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Articulo.Location = new System.Drawing.Point(7, 61);
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(73, 21);
            this.Articulo.TabIndex = 3;
            this.Articulo.Text = "Articulo";
            this.Articulo.UseVisualStyleBackColor = true;
            this.Articulo.CheckedChanged += new System.EventHandler(this.Articulo_CheckedChanged);
            // 
            // Familia
            // 
            this.Familia.AutoSize = true;
            this.Familia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Familia.Location = new System.Drawing.Point(178, 25);
            this.Familia.Name = "Familia";
            this.Familia.Size = new System.Drawing.Size(68, 21);
            this.Familia.TabIndex = 2;
            this.Familia.Text = "Familia";
            this.Familia.UseVisualStyleBackColor = true;
            this.Familia.CheckedChanged += new System.EventHandler(this.Familia_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.ConFactura);
            this.groupBox2.Controls.Add(this.SinFactura);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 53);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione una Opcion";
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
            this.SinFactura.Location = new System.Drawing.Point(178, 25);
            this.SinFactura.Name = "SinFactura";
            this.SinFactura.Size = new System.Drawing.Size(90, 21);
            this.SinFactura.TabIndex = 2;
            this.SinFactura.Text = "Sin factura";
            this.SinFactura.UseVisualStyleBackColor = true;
            this.SinFactura.CheckedChanged += new System.EventHandler(this.SinFactura_CheckedChanged);
            // 
            // BuscarValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(339, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Todo);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BuscarValor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarValor";
            this.Load += new System.EventHandler(this.BuscarValor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Todo;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBBuscar;
        private System.Windows.Forms.RadioButton Empleado;
        private System.Windows.Forms.RadioButton Articulo;
        private System.Windows.Forms.RadioButton Familia;
        private System.Windows.Forms.RadioButton Departamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ConFactura;
        private System.Windows.Forms.RadioButton SinFactura;
    }
}