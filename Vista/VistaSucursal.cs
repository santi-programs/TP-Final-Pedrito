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
    public partial class VistaSucursal : Form
    {
        private ControladorSucursal controlador;
        public VistaSucursal()
        {
            InitializeComponent();
            controlador = new ControladorSucursal();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Direccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para agregar la sucursal.");
            }

            if (!int.TryParse(txt_Stock.Text, out int stock))
            {
                MessageBox.Show("Por favor, complete todos los campos para agregar la sucursal.");
                return;
            }
            Sucursal s = new Sucursal
            {
                Direccion = txt_Direccion.Text,
                Stock = int.Parse(txt_Stock.Text),
            };

            controlador.Agregar(s);
            MessageBox.Show("Sucursal agregada");

            txt_Stock.Clear();
            txt_Direccion.Clear();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text) ||
                string.IsNullOrEmpty(txt_Direccion.Text) ||
                string.IsNullOrEmpty(txt_Stock.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para modificar la sucursal.");
                return;
            }
            Sucursal s = new Sucursal
            {
                Direccion = txt_Direccion.Text,
                Stock = int.Parse(txt_Stock.Text),
            };

            controlador.Modificar(s);
            MessageBox.Show("Sucursal Modificada");

            txt_Stock.Clear();
            txt_Direccion.Clear();
            txt_ID.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID de la sucursal a eliminar.");
                return;
            }
            int id = int.Parse(txt_ID.Text);
            controlador.Eliminar(id);
            MessageBox.Show("Sucursal eliminada");
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

