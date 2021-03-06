﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivoFijo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Usuario.ForeColor = SystemColors.GrayText;
            Usuario.Text = "Usuario";
            Contraseña.ForeColor = SystemColors.GrayText;
            Contraseña.Text = "Contraseña";
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
            this.Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Usuario_KeyPress);
            this.Contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            this.Contraseña.Enter +=new System.EventHandler(this.Contraseña_Enter);

        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text.Length == 0)
            {
                Usuario.Text = "Usuario";
                Usuario.ForeColor = SystemColors.GrayText;
            }
        }

        private void Usuario_KeyPress(object sender, EventArgs e)
        {
            if (Usuario.Text == "Usuario")
            {
                Usuario.Text = "";
                Usuario.ForeColor = SystemColors.WindowText;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text.Length == 0)
            {
                Contraseña.UseSystemPasswordChar = false;
                Contraseña.Text = "Contraseña";
                Contraseña.ForeColor = SystemColors.GrayText;
            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "Contraseña")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = SystemColors.WindowText;
                Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            if (Usuario.Text.Length > 0 && Contraseña.Text.Length > 0 && Usuario.Text != "Usuario" && Contraseña.Text != "Contraseña")
            {
                Clases.Variables.Usuario = Usuario.Text.ToUpper();
                Clases.Variables.Contraseña = Contraseña.Text;
                int resultado = Clases.Login.Validacion();
                if (resultado == 1)
                {

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("Nombre de Usuario o Contraseña incorrectos");
                }
                else
                    MessageBox.Show("Error al conectar, porfavor verifique la conexion al servidor.");

            }
            else
            {
                MessageBox.Show("No debe dejar Usuario y/o contraseña vacios");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Auxiliares.ContraseñaBD contraseñaBD = new Auxiliares.ContraseñaBD();
            contraseñaBD.ShowDialog();
            if (contraseñaBD.DialogResult == DialogResult.OK)
            {
                Auxiliares.ConexionBD conexionBD = new Auxiliares.ConexionBD();
                conexionBD.ShowDialog();
            }
        }
    }
}
