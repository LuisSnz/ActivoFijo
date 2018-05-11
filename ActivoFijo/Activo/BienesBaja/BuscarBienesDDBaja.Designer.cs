namespace ActivoFijo.Activo.BienesBaja
{
    partial class BuscarBienesDDBaja
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
            this.Todo = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBBuscar = new System.Windows.Forms.ComboBox();
            this.Empleado = new System.Windows.Forms.RadioButton();
            this.Articulo = new System.Windows.Forms.RadioButton();
            this.Motivo = new System.Windows.Forms.RadioButton();
            this.Factura = new System.Windows.Forms.RadioButton();
            this.Etiqueta = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Todo
            // 
            this.Todo.BackColor = System.Drawing.Color.White;
            this.Todo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Todo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todo.Location = new System.Drawing.Point(119, 214);
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
            this.Cancelar.Location = new System.Drawing.Point(228, 214);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(97, 35);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.White;
            this.Buscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Buscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(12, 214);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(97, 35);
            this.Buscar.TabIndex = 12;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.CBBuscar);
            this.groupBox1.Controls.Add(this.Empleado);
            this.groupBox1.Controls.Add(this.Articulo);
            this.groupBox1.Controls.Add(this.Motivo);
            this.groupBox1.Controls.Add(this.Factura);
            this.groupBox1.Controls.Add(this.Etiqueta);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion";
            // 
            // CBBuscar
            // 
            this.CBBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Location = new System.Drawing.Point(6, 143);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(300, 25);
            this.CBBuscar.TabIndex = 5;
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.Location = new System.Drawing.Point(6, 105);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(84, 21);
            this.Empleado.TabIndex = 4;
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
            // Motivo
            // 
            this.Motivo.AutoSize = true;
            this.Motivo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motivo.Location = new System.Drawing.Point(178, 19);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(116, 21);
            this.Motivo.TabIndex = 2;
            this.Motivo.Text = "Motivo de Baja";
            this.Motivo.UseVisualStyleBackColor = true;
            this.Motivo.CheckedChanged += new System.EventHandler(this.Motivo_CheckedChanged);
            // 
            // Factura
            // 
            this.Factura.AutoSize = true;
            this.Factura.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factura.Location = new System.Drawing.Point(177, 61);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(97, 21);
            this.Factura.TabIndex = 1;
            this.Factura.Text = "No. Factura";
            this.Factura.UseVisualStyleBackColor = true;
            this.Factura.CheckedChanged += new System.EventHandler(this.Factura_CheckedChanged);
            // 
            // Etiqueta
            // 
            this.Etiqueta.AutoSize = true;
            this.Etiqueta.Checked = true;
            this.Etiqueta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta.Location = new System.Drawing.Point(6, 19);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(74, 21);
            this.Etiqueta.TabIndex = 0;
            this.Etiqueta.TabStop = true;
            this.Etiqueta.Text = "Etiqueta";
            this.Etiqueta.UseVisualStyleBackColor = true;
            this.Etiqueta.CheckedChanged += new System.EventHandler(this.Etiqueta_CheckedChanged);
            // 
            // BuscarBienesDDBaja
            // 
            this.AcceptButton = this.Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(337, 263);
            this.Controls.Add(this.Todo);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BuscarBienesDDBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.BuscarBienesDDBaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Todo;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBBuscar;
        private System.Windows.Forms.RadioButton Empleado;
        private System.Windows.Forms.RadioButton Articulo;
        private System.Windows.Forms.RadioButton Motivo;
        private System.Windows.Forms.RadioButton Factura;
        private System.Windows.Forms.RadioButton Etiqueta;
    }
}