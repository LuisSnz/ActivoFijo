﻿using System;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Familias
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            Descripcion.Text = Clases.Variables.DescripcionFamilia;
            Saldo.Text = Clases.Variables.SaldoInicial;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text.Length > 0 && Saldo.Text.Length>0)
            {
                string ConnString = Clases.Variables.scon;
                string SqlString = "Update Familia set Descripcion='" + Descripcion.Text + "',Saldo_Inicial="+Saldo.Text+" where Id=" + Clases.Variables.IDFamilia + ";";
                bool resultado = Clases.Inserciones.Ejecucion(SqlString);
                if (resultado == true)
                {
                    MessageBox.Show("Familia modificada correctamente");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error inesperado \n" + Clases.Variables.Error);
            }
            else
                MessageBox.Show("Los campos deben contener un valor");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Saldo_Leave(object sender, EventArgs e)
        {
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(Saldo.Text, out numero);
            if ((!(bln)) && Saldo.Text.Length > 0)
            {
                Saldo.Clear();
                MessageBox.Show("Saldo Incorrecto");
            }
        }
    }
}
