﻿namespace ActivoFijo.Catalogos.SubDirecciones
{
    partial class Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 52);
            this.panel1.TabIndex = 15;
            // 
            // Descripcion
            // 
            this.Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Descripcion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(111, 14);
            this.Descripcion.MaxLength = 30;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(206, 25);
            this.Descripcion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "SubDireccion";
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.White;
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(204, 73);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(87, 32);
            this.Cancelar.TabIndex = 14;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.White;
            this.Guardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(71, 73);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(80, 32);
            this.Guardar.TabIndex = 13;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Modificar
            // 
            this.AcceptButton = this.Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(369, 119);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar SubDirecciones";
            this.Load += new System.EventHandler(this.Modificar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
    }
}