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
            if (string.IsNullOrEmpty(txt_Nombre.Text))
            {
                MessageBox.Show("Por favor, complete el campo de nombre para agregar la categoria.");
            }
            Categoria c = new Categoria()
            {
                Nombre = txt_Nombre.Text
            };

            controlaldor.Agregar(c);
            MessageBox.Show("Categoria agregada");
                txt_Nombre.Clear();
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IDProducto.Text) || string.IsNullOrEmpty(txt_IDCategoria.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos para asignar la categoria al producto.");
                return;
            }
            int idProducto = int.Parse(txt_IDProducto.Text);
            int idCategoria = int.Parse(txt_IDCategoria.Text);

            controlaldor.Asignar(idProducto, idCategoria);
            MessageBox.Show("Categoria asignada al producto");

            txt_Nombre.Clear();
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
