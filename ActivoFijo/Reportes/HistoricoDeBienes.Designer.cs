namespace ActivoFijo.Reportes
{
    partial class HistoricoDeBienes
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
            this.Etiqueta = new System.Windows.Forms.ComboBox();
            this.GridHistorico = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Etiqueta
            // 
            this.Etiqueta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Etiqueta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Etiqueta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta.FormattingEnabled = true;
            this.Etiqueta.Location = new System.Drawing.Point(87, 18);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(121, 25);
            this.Etiqueta.TabIndex = 5;
            this.Etiqueta.SelectedIndexChanged += new System.EventHandler(this.Etiqueta_SelectedIndexChanged);
            // 
            // GridHistorico
            // 
            this.GridHistorico.AllowUserToAddRows = false;
            this.GridHistorico.AllowUserToDeleteRows = false;
            this.GridHistorico.AllowUserToOrderColumns = true;
            this.GridHistorico.AllowUserToResizeColumns = false;
            this.GridHistorico.AllowUserToResizeRows = false;
            this.GridHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridHistorico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridHistorico.BackgroundColor = System.Drawing.Color.White;
            this.GridHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistorico.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridHistorico.Location = new System.Drawing.Point(15, 49);
            this.GridHistorico.MultiSelect = false;
            this.GridHistorico.Name = "GridHistorico";
            this.GridHistorico.ReadOnly = true;
            this.GridHistorico.Size = new System.Drawing.Size(453, 255);
            this.GridHistorico.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Etiqueta);
            this.panel1.Controls.Add(this.GridHistorico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 324);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etiqueta:";
            // 
            // HistoricoDeBienes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(507, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HistoricoDeBienes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico De Bienes";
            this.Load += new System.EventHandler(this.HistoricoDeBienes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Etiqueta;
        private System.Windows.Forms.DataGridView GridHistorico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}