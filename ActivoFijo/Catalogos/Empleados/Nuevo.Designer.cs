namespace ActivoFijo.Catalogos.Empleados
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboJefe = new System.Windows.Forms.ComboBox();
            this.FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.NumLicencia = new System.Windows.Forms.TextBox();
            this.comboDepto = new System.Windows.Forms.ComboBox();
            this.NombreM = new System.Windows.Forms.TextBox();
            this.Materno = new System.Windows.Forms.TextBox();
            this.Paterno = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkSinPliegos = new System.Windows.Forms.CheckBox();
            this.checkBaja = new System.Windows.Forms.CheckBox();
            this.checkJefe = new System.Windows.Forms.CheckBox();
            this.checkPliegos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Motivo = new System.Windows.Forms.TextBox();
            this.checkBloqueado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(601, 270);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(107, 39);
            this.Cancelar.TabIndex = 24;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.White;
            this.Guardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(601, 203);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(107, 39);
            this.Guardar.TabIndex = 23;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboJefe);
            this.panel2.Controls.Add(this.FechaVencimiento);
            this.panel2.Controls.Add(this.NumLicencia);
            this.panel2.Controls.Add(this.comboDepto);
            this.panel2.Controls.Add(this.NombreM);
            this.panel2.Controls.Add(this.Materno);
            this.panel2.Controls.Add(this.Paterno);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 278);
            this.panel2.TabIndex = 20;
            // 
            // comboJefe
            // 
            this.comboJefe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboJefe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboJefe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboJefe.FormattingEnabled = true;
            this.comboJefe.Location = new System.Drawing.Point(145, 232);
            this.comboJefe.Name = "comboJefe";
            this.comboJefe.Size = new System.Drawing.Size(380, 25);
            this.comboJefe.TabIndex = 9;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVencimiento.Location = new System.Drawing.Point(145, 201);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(380, 25);
            this.FechaVencimiento.TabIndex = 8;
            this.FechaVencimiento.Value = new System.DateTime(2018, 4, 2, 0, 0, 0, 0);
            // 
            // NumLicencia
            // 
            this.NumLicencia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumLicencia.Location = new System.Drawing.Point(145, 170);
            this.NumLicencia.MaxLength = 10;
            this.NumLicencia.Name = "NumLicencia";
            this.NumLicencia.Size = new System.Drawing.Size(380, 25);
            this.NumLicencia.TabIndex = 7;
            // 
            // comboDepto
            // 
            this.comboDepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboDepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDepto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepto.FormattingEnabled = true;
            this.comboDepto.Location = new System.Drawing.Point(145, 139);
            this.comboDepto.Name = "comboDepto";
            this.comboDepto.Size = new System.Drawing.Size(380, 25);
            this.comboDepto.TabIndex = 6;
            // 
            // NombreM
            // 
            this.NombreM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NombreM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreM.Location = new System.Drawing.Point(146, 108);
            this.NombreM.MaxLength = 70;
            this.NombreM.Name = "NombreM";
            this.NombreM.Size = new System.Drawing.Size(380, 25);
            this.NombreM.TabIndex = 5;
            // 
            // Materno
            // 
            this.Materno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Materno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Materno.Location = new System.Drawing.Point(146, 77);
            this.Materno.MaxLength = 150;
            this.Materno.Name = "Materno";
            this.Materno.Size = new System.Drawing.Size(380, 25);
            this.Materno.TabIndex = 4;
            // 
            // Paterno
            // 
            this.Paterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Paterno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paterno.Location = new System.Drawing.Point(146, 46);
            this.Paterno.MaxLength = 150;
            this.Paterno.Name = "Paterno";
            this.Paterno.Size = new System.Drawing.Size(380, 25);
            this.Paterno.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(146, 13);
            this.Nombre.MaxLength = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(380, 25);
            this.Nombre.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Apellido Materno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Apellido Paterno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Jefe Dpto.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Num. Licencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre a mostrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre(s)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkSinPliegos);
            this.panel1.Controls.Add(this.checkBaja);
            this.panel1.Controls.Add(this.checkJefe);
            this.panel1.Controls.Add(this.checkPliegos);
            this.panel1.Location = new System.Drawing.Point(566, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 137);
            this.panel1.TabIndex = 22;
            // 
            // checkSinPliegos
            // 
            this.checkSinPliegos.AutoSize = true;
            this.checkSinPliegos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSinPliegos.Location = new System.Drawing.Point(13, 99);
            this.checkSinPliegos.Name = "checkSinPliegos";
            this.checkSinPliegos.Size = new System.Drawing.Size(130, 21);
            this.checkSinPliegos.TabIndex = 17;
            this.checkSinPliegos.Text = "Sin Validar Pliego";
            this.checkSinPliegos.UseVisualStyleBackColor = true;
            // 
            // checkBaja
            // 
            this.checkBaja.AutoSize = true;
            this.checkBaja.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBaja.Location = new System.Drawing.Point(13, 70);
            this.checkBaja.Name = "checkBaja";
            this.checkBaja.Size = new System.Drawing.Size(54, 21);
            this.checkBaja.TabIndex = 16;
            this.checkBaja.Text = "Baja";
            this.checkBaja.UseVisualStyleBackColor = true;
            // 
            // checkJefe
            // 
            this.checkJefe.AutoSize = true;
            this.checkJefe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkJefe.Location = new System.Drawing.Point(13, 41);
            this.checkJefe.Name = "checkJefe";
            this.checkJefe.Size = new System.Drawing.Size(71, 21);
            this.checkJefe.TabIndex = 15;
            this.checkJefe.Text = "Es Jefe";
            this.checkJefe.UseVisualStyleBackColor = true;
            // 
            // checkPliegos
            // 
            this.checkPliegos.AutoSize = true;
            this.checkPliegos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPliegos.Location = new System.Drawing.Point(13, 12);
            this.checkPliegos.Name = "checkPliegos";
            this.checkPliegos.Size = new System.Drawing.Size(140, 21);
            this.checkPliegos.TabIndex = 14;
            this.checkPliegos.Text = "Activo para pliegos";
            this.checkPliegos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Motivo);
            this.groupBox1.Controls.Add(this.checkBloqueado);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 92);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bloqueo";
            // 
            // Motivo
            // 
            this.Motivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Motivo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motivo.Location = new System.Drawing.Point(60, 51);
            this.Motivo.MaxLength = 100;
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(461, 25);
            this.Motivo.TabIndex = 12;
            // 
            // checkBloqueado
            // 
            this.checkBloqueado.AutoSize = true;
            this.checkBloqueado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBloqueado.Location = new System.Drawing.Point(8, 24);
            this.checkBloqueado.Name = "checkBloqueado";
            this.checkBloqueado.Size = new System.Drawing.Size(151, 21);
            this.checkBloqueado.TabIndex = 11;
            this.checkBloqueado.Text = "Empleado Bloqueado";
            this.checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Motivo";
            // 
            // Nuevo
            // 
            this.AcceptButton = this.Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(750, 414);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboJefe;
        private System.Windows.Forms.DateTimePicker FechaVencimiento;
        private System.Windows.Forms.TextBox NumLicencia;
        private System.Windows.Forms.ComboBox comboDepto;
        private System.Windows.Forms.TextBox NombreM;
        private System.Windows.Forms.TextBox Materno;
        private System.Windows.Forms.TextBox Paterno;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkSinPliegos;
        private System.Windows.Forms.CheckBox checkBaja;
        private System.Windows.Forms.CheckBox checkJefe;
        private System.Windows.Forms.CheckBox checkPliegos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Motivo;
        private System.Windows.Forms.CheckBox checkBloqueado;
        private System.Windows.Forms.Label label8;
    }
}