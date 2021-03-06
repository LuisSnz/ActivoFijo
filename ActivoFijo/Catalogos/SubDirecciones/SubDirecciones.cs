﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivoFijo.Catalogos.SubDirecciones
{
    public partial class SubDirecciones : Form
    {
        public SubDirecciones()
        {
            InitializeComponent();
        }

        private void SubDirecciones_Load(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select ID, Descripcion from subdireccion";
            Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Catalogos.SubDirecciones.Nuevo nuevo = new Nuevo();
            nuevo.ShowDialog();
            if (nuevo.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Catalogos.SubDirecciones.Modificar modificarSD = new Modificar();
            modificarSD.ShowDialog();
            if (modificarSD.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void GridSubD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Catalogos.SubDirecciones.Modificar modificarSD = new Modificar();
            modificarSD.ShowDialog();
            if (modificarSD.DialogResult == DialogResult.OK)
                Clases.LLenadoGrids.llenarGrid(GridSubD, Clases.Variables.ConsultaBuscar, "subdireccion");
        }

        private void GridSubD_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Variables.IdSubD = GridSubD.CurrentRow.Cells[0].Value.ToString();
            Clases.Variables.DescripcionSubD = GridSubD.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
