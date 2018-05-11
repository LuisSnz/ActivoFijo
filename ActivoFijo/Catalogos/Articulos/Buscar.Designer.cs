namespace ActivoFijo.Catalogos.Articulos
{
    partial class BuscarArticulo
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
            this.MostrarTodo = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RBArticulo = new System.Windows.Forms.RadioButton();
            this.RBFamilia = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MostrarTodo
            // 
            this.MostrarTodo.BackColor = System.Drawing.Color.White;
            this.MostrarTodo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarTodo.Location = new System.Drawing.Point(141, 178);
            this.MostrarTodo.Name = "MostrarTodo";
            this.MostrarTodo.Size = new System.Drawing.Size(102, 34);
            this.MostrarTodo.TabIndex = 20;
            this.MostrarTodo.Text = "Mostrar Todo";
            this.MostrarTodo.UseVisualStyleBackColor = false;
            this.MostrarTodo.Click += new System.EventHandler(this.MostrarTodo_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.White;
            this.Buscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(14, 178);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(94, 34);
            this.Buscar.TabIndex = 18;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(270, 178);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(94, 34);
            this.Cancelar.TabIndex = 19;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 144);
            this.panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.RBArticulo);
            this.groupBox1.Controls.Add(this.RBFamilia);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 25);
            this.comboBox1.TabIndex = 14;
            // 
            // RBArticulo
            // 
            this.RBArticulo.AutoSize = true;
            this.RBArticulo.Checked = true;
            this.RBArticulo.Location = new System.Drawing.Point(64, 25);
            this.RBArticulo.Name = "RBArticulo";
            this.RBArticulo.Size = new System.Drawing.Size(73, 21);
            this.RBArticulo.TabIndex = 12;
            this.RBArticulo.TabStop = true;
            this.RBArticulo.Text = "Articulo";
            this.RBArticulo.UseVisualStyleBackColor = true;
            this.RBArticulo.CheckedChanged += new System.EventHandler(this.RBArticulo_CheckedChanged);
            // 
            // RBFamilia
            // 
            this.RBFamilia.AutoSize = true;
            this.RBFamilia.Location = new System.Drawing.Point(186, 25);
            this.RBFamilia.Name = "RBFamilia";
            this.RBFamilia.Size = new System.Drawing.Size(68, 21);
            this.RBFamilia.TabIndex = 13;
            this.RBFamilia.TabStop = true;
            this.RBFamilia.Text = "Familia";
            this.RBFamilia.UseVisualStyleBackColor = true;
            this.RBFamilia.CheckedChanged += new System.EventHandler(this.RBFamilia_CheckedChanged);
            // 
            // BuscarArticulo
            // 
            this.AcceptButton = this.Buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(379, 226);
            this.Controls.Add(this.MostrarTodo);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Articulo";
            this.Load += new System.EventHandler(this.BuscarArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostrarTodo;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton RBArticulo;
        private System.Windows.Forms.RadioButton RBFamilia;
    }
}