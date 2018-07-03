namespace ActivoFijo.Activo.Bienes
{
    partial class ImprimirPorRango
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirPorRango));
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBFactura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.CBNombre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(260, 249);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(91, 32);
            this.Cancelar.TabIndex = 19;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.White;
            this.Aceptar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(83, 249);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(91, 32);
            this.Aceptar.TabIndex = 5;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBFactura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBArticulo);
            this.groupBox1.Controls.Add(this.CBNombre);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 189);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Factura";
            // 
            // CBFactura
            // 
            this.CBFactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBFactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBFactura.FormattingEnabled = true;
            this.CBFactura.Location = new System.Drawing.Point(6, 148);
            this.CBFactura.Name = "CBFactura";
            this.CBFactura.Size = new System.Drawing.Size(409, 25);
            this.CBFactura.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Empleado";
            // 
            // CBArticulo
            // 
            this.CBArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(6, 100);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(409, 25);
            this.CBArticulo.TabIndex = 2;
            // 
            // CBNombre
            // 
            this.CBNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBNombre.FormattingEnabled = true;
            this.CBNombre.Location = new System.Drawing.Point(6, 52);
            this.CBNombre.Name = "CBNombre";
            this.CBNombre.Size = new System.Drawing.Size(409, 25);
            this.CBNombre.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 216);
            this.panel1.TabIndex = 15;
            // 
            // ImprimirPorRango
            // 
            this.AcceptButton = this.Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(455, 299);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImprimirPorRango";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir por Rango";
            this.Load += new System.EventHandler(this.ImprimirPorRango_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.ComboBox CBNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBFactura;
    }
}