using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Catalogos.Articulos
{
    public partial class BuscarArticulo : Form
    {
        public BuscarArticulo()
        {
            InitializeComponent();
        }

        private void BuscarArticulo_Load(object sender, EventArgs e)
        {
            Clases.Articulos.CBBuscarArticulo(comboBox1);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (RBArticulo.Checked == true)
                Clases.Variables.ConsultaBuscar = "select CatArticulos.Id, CatArticulos.Descripcion as Articulo, Familia.Descripcion as Familia, " +
                "CatArticulos.inventariable as Inventariable, CatArticulos.Medida,TipoArticulo.Descripcion as Tipo, CatArticulos.ActivoContratos as Contrato " +
                "from CatArticulos inner join Familia on Familia.Id=CatArticulos.IdFamilia left outer join TipoArticulo on TipoArticulo.id=CatArticulos.IdTipoArticulo " +
                "where CatArticulos.Descripcion LIKE '%" + comboBox1.Text + "%' order by id";
            else if (RBFamilia.Checked == true)
                Clases.Variables.ConsultaBuscar = "select CatArticulos.Id, CatArticulos.Descripcion as Articulo, Familia.Descripcion as Familia, " +
                "CatArticulos.inventariable as Inventariable, CatArticulos.Medida,TipoArticulo.Descripcion as Tipo, CatArticulos.ActivoContratos as Contrato " +
                "from CatArticulos inner join Familia on Familia.Id=CatArticulos.IdFamilia left outer join TipoArticulo on TipoArticulo.id=CatArticulos.IdTipoArticulo " +
                "where Familia.Descripcion LIKE '%" + comboBox1.Text + "%' order by id";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RBArticulo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBArticulo.Checked == true)
                Clases.Articulos.CBBuscarArticulo(comboBox1);
        }

        private void RBFamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (RBFamilia.Checked == true)
                Clases.Articulos.CBArticulosFamilia(comboBox1);
        }

        private void MostrarTodo_Click(object sender, EventArgs e)
        {
            Clases.Variables.ConsultaBuscar = "select CatArticulos.Id, CatArticulos.Descripcion as Articulo, Familia.Descripcion as Familia, " +
                "CatArticulos.inventariable as Inventariable, CatArticulos.Medida,TipoArticulo.Descripcion as Tipo, CatArticulos.ActivoContratos as Contrato " +
                "from CatArticulos inner join Familia on Familia.Id=CatArticulos.IdFamilia left outer join TipoArticulo on TipoArticulo.id=CatArticulos.IdTipoArticulo";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
