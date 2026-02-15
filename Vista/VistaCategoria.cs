using Controlador;
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
    public partial class VistaCategoria : Form
    {
        private ControladorCategoria controlaldor;
        public VistaCategoria()
        {
            controlaldor = new ControladorCategoria();
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria()
            {
                Nombre = txt_Nombre.Text
            };

            controlaldor.Agregar(c);
            MessageBox.Show("Categoria agregada");
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            int idProducto = int.Parse(txt_IDProducto.Text);
            int idCategoria = int.Parse(txt_IDCategoria.Text);

            controlaldor.Asignar(idProducto, idCategoria);
            MessageBox.Show("Categoria asignada al producto");

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            List<Categoria> lista = controlaldor.Listar();

            VistaListaCategorias vista = new VistaListaCategorias(lista);
            vista.ShowDialog();

        }
    }
}
