namespace ActivoFijo.Catalogos.Articulos
{
    partial class Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo));
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CHArticuloContrato = new System.Windows.Forms.CheckBox();
            this.CHBInventariable = new System.Windows.Forms.CheckBox();
            this.CBFamilia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBMedida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(302, 341);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(107, 30);
            this.Cancelar.TabIndex = 21;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.White;
            this.Guardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(80, 341);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(107, 30);
            this.Guardar.TabIndex = 20;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CHArticuloContrato);
            this.panel1.Controls.Add(this.CHBInventariable);
            this.panel1.Controls.Add(this.CBFamilia);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CBMedida);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CBArticulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBArticulo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 304);
            this.panel1.TabIndex = 19;
            // 
            // CHArticuloContrato
            // 
            this.CHArticuloContrato.AutoSize = true;
            this.CHArticuloContrato.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHArticuloContrato.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHArticuloContrato.Location = new System.Drawing.Point(27, 259);
            this.CHArticuloContrato.Name = "CHArticuloContrato";
            this.CHArticuloContrato.Size = new System.Drawing.Size(246, 21);
            this.CHArticuloContrato.TabIndex = 13;
            this.CHArticuloContrato.Text = "Articulo solo para uso de un Contrato";
            this.CHArticuloContrato.UseVisualStyleBackColor = true;
            this.CHArticuloContrato.CheckedChanged += new System.EventHandler(this.CHArticuloContrato_CheckedChanged);
            // 
            // CHBInventariable
            // 
            this.CHBInventariable.AutoSize = true;
            this.CHBInventariable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHBInventariable.Checked = true;
            this.CHBInventariable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHBInventariable.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBInventariable.Location = new System.Drawing.Point(27, 225);
            this.CHBInventariable.Name = "CHBInventariable";
            this.CHBInventariable.Size = new System.Drawing.Size(103, 21);
            this.CHBInventariable.TabIndex = 12;
            this.CHBInventariable.Text = "Inventariable";
            this.CHBInventariable.UseVisualStyleBackColor = true;
            this.CHBInventariable.CheckedChanged += new System.EventHandler(this.CHBInventariable_CheckedChanged);
            // 
            // CBFamilia
            // 
            this.CBFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBFamilia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFamilia.ForeColor = System.Drawing.Color.Black;
            this.CBFamilia.FormattingEnabled = true;
            this.CBFamilia.Location = new System.Drawing.Point(143, 181);
            this.CBFamilia.Name = "CBFamilia";
            this.CBFamilia.Size = new System.Drawing.Size(282, 25);
            this.CBFamilia.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Familia Activo Fijo";
            // 
            // CBMedida
            // 
            this.CBMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBMedida.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMedida.FormattingEnabled = true;
            this.CBMedida.Location = new System.Drawing.Point(143, 138);
            this.CBMedida.Name = "CBMedida";
            this.CBMedida.Size = new System.Drawing.Size(282, 25);
            this.CBMedida.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unidad de Medida";
            // 
            // CBArticulo
            // 
            this.CBArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBArticulo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(143, 95);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(282, 25);
            this.CBArticulo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de articulo";
            // 
            // TBArticulo
            // 
            this.TBArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBArticulo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBArticulo.Location = new System.Drawing.Point(26, 57);
            this.TBArticulo.MaxLength = 250;
            this.TBArticulo.Name = "TBArticulo";
            this.TBArticulo.Size = new System.Drawing.Size(399, 25);
            this.TBArticulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del  Articulo o Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Generales :";
            // 
            // Nuevo
            // 
            this.AcceptButton = this.Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(490, 391);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBFamilia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHArticuloContrato;
        private System.Windows.Forms.CheckBox CHBInventariable;
    }
}