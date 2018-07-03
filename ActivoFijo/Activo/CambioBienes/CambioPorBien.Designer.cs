namespace ActivoFijo.Activo.CambioBienes
{
    partial class CambioPorBien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioPorBien));
            this.Cancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.CBNuevoResguardo = new System.Windows.Forms.ComboBox();
            this.TBNuevoResguardo = new System.Windows.Forms.TextBox();
            this.TBDepartamentoA = new System.Windows.Forms.TextBox();
            this.TBResguardoA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Cambiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBObservaciones = new System.Windows.Forms.TextBox();
            this.TBArticulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBOrdenCompra = new System.Windows.Forms.Label();
            this.LBEtiqueta = new System.Windows.Forms.Label();
            this.LBId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(363, 253);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(123, 28);
            this.Cancelar.TabIndex = 22;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.CBNuevoResguardo);
            this.panel2.Controls.Add(this.TBNuevoResguardo);
            this.panel2.Controls.Add(this.TBDepartamentoA);
            this.panel2.Controls.Add(this.TBResguardoA);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 107);
            this.panel2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "==>";
            // 
            // CBNuevoResguardo
            // 
            this.CBNuevoResguardo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBNuevoResguardo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBNuevoResguardo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNuevoResguardo.FormattingEnabled = true;
            this.CBNuevoResguardo.Location = new System.Drawing.Point(349, 36);
            this.CBNuevoResguardo.Name = "CBNuevoResguardo";
            this.CBNuevoResguardo.Size = new System.Drawing.Size(282, 23);
            this.CBNuevoResguardo.TabIndex = 15;
            this.CBNuevoResguardo.SelectedIndexChanged += new System.EventHandler(this.CBNuevoResguardo_SelectedIndexChanged);
            // 
            // TBNuevoResguardo
            // 
            this.TBNuevoResguardo.Enabled = false;
            this.TBNuevoResguardo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNuevoResguardo.Location = new System.Drawing.Point(349, 67);
            this.TBNuevoResguardo.Name = "TBNuevoResguardo";
            this.TBNuevoResguardo.ReadOnly = true;
            this.TBNuevoResguardo.Size = new System.Drawing.Size(282, 22);
            this.TBNuevoResguardo.TabIndex = 13;
            // 
            // TBDepartamentoA
            // 
            this.TBDepartamentoA.Enabled = false;
            this.TBDepartamentoA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDepartamentoA.Location = new System.Drawing.Point(20, 67);
            this.TBDepartamentoA.Name = "TBDepartamentoA";
            this.TBDepartamentoA.ReadOnly = true;
            this.TBDepartamentoA.Size = new System.Drawing.Size(288, 22);
            this.TBDepartamentoA.TabIndex = 12;
            // 
            // TBResguardoA
            // 
            this.TBResguardoA.Enabled = false;
            this.TBResguardoA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBResguardoA.Location = new System.Drawing.Point(20, 36);
            this.TBResguardoA.Name = "TBResguardoA";
            this.TBResguardoA.ReadOnly = true;
            this.TBResguardoA.Size = new System.Drawing.Size(288, 22);
            this.TBResguardoA.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(346, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Nuevo Resguardo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Resguardo a:";
            // 
            // Cambiar
            // 
            this.Cambiar.BackColor = System.Drawing.Color.White;
            this.Cambiar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cambiar.Location = new System.Drawing.Point(196, 253);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(126, 28);
            this.Cambiar.TabIndex = 14;
            this.Cambiar.Text = "Cambiar";
            this.Cambiar.UseVisualStyleBackColor = false;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TBObservaciones);
            this.panel1.Controls.Add(this.TBArticulo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LBOrdenCompra);
            this.panel1.Controls.Add(this.LBEtiqueta);
            this.panel1.Controls.Add(this.LBId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 117);
            this.panel1.TabIndex = 20;
            // 
            // TBObservaciones
            // 
            this.TBObservaciones.Enabled = false;
            this.TBObservaciones.Location = new System.Drawing.Point(117, 77);
            this.TBObservaciones.Name = "TBObservaciones";
            this.TBObservaciones.ReadOnly = true;
            this.TBObservaciones.Size = new System.Drawing.Size(464, 25);
            this.TBObservaciones.TabIndex = 11;
            // 
            // TBArticulo
            // 
            this.TBArticulo.Enabled = false;
            this.TBArticulo.Location = new System.Drawing.Point(58, 42);
            this.TBArticulo.Name = "TBArticulo";
            this.TBArticulo.ReadOnly = true;
            this.TBArticulo.Size = new System.Drawing.Size(523, 25);
            this.TBArticulo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Observaciones:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bien:";
            // 
            // LBOrdenCompra
            // 
            this.LBOrdenCompra.AutoSize = true;
            this.LBOrdenCompra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBOrdenCompra.Location = new System.Drawing.Point(389, 12);
            this.LBOrdenCompra.Name = "LBOrdenCompra";
            this.LBOrdenCompra.Size = new System.Drawing.Size(40, 17);
            this.LBOrdenCompra.TabIndex = 6;
            this.LBOrdenCompra.Text = "xxxx";
            // 
            // LBEtiqueta
            // 
            this.LBEtiqueta.AutoSize = true;
            this.LBEtiqueta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEtiqueta.Location = new System.Drawing.Point(179, 12);
            this.LBEtiqueta.Name = "LBEtiqueta";
            this.LBEtiqueta.Size = new System.Drawing.Size(40, 17);
            this.LBEtiqueta.TabIndex = 5;
            this.LBEtiqueta.Text = "xxxx";
            // 
            // LBId
            // 
            this.LBId.AutoSize = true;
            this.LBId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBId.Location = new System.Drawing.Point(47, 11);
            this.LBId.Name = "LBId";
            this.LBId.Size = new System.Drawing.Size(40, 17);
            this.LBId.TabIndex = 4;
            this.LBId.Text = "xxxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Orden de Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etiqueta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // CambioPorBien
            // 
            this.AcceptButton = this.Cambiar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(680, 295);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cambiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CambioPorBien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio Por Bien";
            this.Load += new System.EventHandler(this.CambioPorBien_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CBNuevoResguardo;
        private System.Windows.Forms.Button Cambiar;
        private System.Windows.Forms.TextBox TBNuevoResguardo;
        private System.Windows.Forms.TextBox TBDepartamentoA;
        private System.Windows.Forms.TextBox TBResguardoA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBObservaciones;
        private System.Windows.Forms.TextBox TBArticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBOrdenCompra;
        private System.Windows.Forms.Label LBEtiqueta;
        private System.Windows.Forms.Label LBId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}