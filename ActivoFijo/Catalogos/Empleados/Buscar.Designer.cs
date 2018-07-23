namespace ActivoFijo.Catalogos.Empleados
{
    partial class BuscarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarEmpleado));
            this.MostrarTodo = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioJefe = new System.Windows.Forms.RadioButton();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.radioDeptos = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MostrarTodo
            // 
            this.MostrarTodo.BackColor = System.Drawing.Color.White;
            this.MostrarTodo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarTodo.Location = new System.Drawing.Point(134, 115);
            this.MostrarTodo.Name = "MostrarTodo";
            this.MostrarTodo.Size = new System.Drawing.Size(128, 29);
            this.MostrarTodo.TabIndex = 20;
            this.MostrarTodo.Text = "Mostrar todo";
            this.MostrarTodo.UseVisualStyleBackColor = false;
            this.MostrarTodo.Click += new System.EventHandler(this.MostrarTodo_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(302, 115);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(79, 29);
            this.Cancelar.TabIndex = 19;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.White;
            this.Buscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(29, 115);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 29);
            this.Buscar.TabIndex = 18;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioJefe);
            this.groupBox1.Controls.Add(this.comboBuscar);
            this.groupBox1.Controls.Add(this.radioDeptos);
            this.groupBox1.Controls.Add(this.radioNombre);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 87);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro :";
            // 
            // radioJefe
            // 
            this.radioJefe.AutoSize = true;
            this.radioJefe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioJefe.Location = new System.Drawing.Point(254, 24);
            this.radioJefe.Name = "radioJefe";
            this.radioJefe.Size = new System.Drawing.Size(51, 21);
            this.radioJefe.TabIndex = 2;
            this.radioJefe.Text = "Jefe";
            this.radioJefe.UseVisualStyleBackColor = true;
            this.radioJefe.CheckedChanged += new System.EventHandler(this.radioJefe_CheckedChanged);
            // 
            // comboBuscar
            // 
            this.comboBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Location = new System.Drawing.Point(6, 51);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(352, 25);
            this.comboBuscar.TabIndex = 12;
            // 
            // radioDeptos
            // 
            this.radioDeptos.AutoSize = true;
            this.radioDeptos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDeptos.Location = new System.Drawing.Point(111, 24);
            this.radioDeptos.Name = "radioDeptos";
            this.radioDeptos.Size = new System.Drawing.Size(110, 21);
            this.radioDeptos.TabIndex = 1;
            this.radioDeptos.Text = "Departamento";
            this.radioDeptos.UseVisualStyleBackColor = true;
            this.radioDeptos.CheckedChanged += new System.EventHandler(this.radioDeptos_CheckedChanged);
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Checked = true;
            this.radioNombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNombre.Location = new System.Drawing.Point(6, 24);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(74, 21);
            this.radioNombre.TabIndex = 0;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Nombre";
            this.radioNombre.UseVisualStyleBackColor = true;
            this.radioNombre.CheckedChanged += new System.EventHandler(this.radioNombre_CheckedChanged);
            // 
            // BuscarEmpleado
            // 
            this.AcceptButton = this.Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(411, 158);
            this.Controls.Add(this.MostrarTodo);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BuscarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Empleado";
            this.Load += new System.EventHandler(this.BuscarEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostrarTodo;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioJefe;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.RadioButton radioDeptos;
        private System.Windows.Forms.RadioButton radioNombre;
    }
}