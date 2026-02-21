using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class VistaListaCategorias : Form
    {
        public VistaListaCategorias(List<Categoria> categorias)
        {
            InitializeComponent();

            dgv_Categorias.DataSource = categorias;

            dgv_Categorias.Columns["CategoriaID"].HeaderText = "ID";
            dgv_Categorias.Columns["Nombre"].HeaderText = "Nombre de Categoría";

            dgv_Categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
