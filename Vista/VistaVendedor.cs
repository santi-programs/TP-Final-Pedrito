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
    public partial class VistaVendedor : Form
    {
        private ControladorVendedor controlador;
        public VistaVendedor()
        {
            InitializeComponent();
            controlador = new ControladorVendedor();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Nombre.Text) ||
               string.IsNullOrEmpty(txt_Apellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para agregar el vendedor.");
                return;
            }
            Vendedor v = new Vendedor
            {
                Nombre = txt_Nombre.Text,
                Apellido = txt_Apellido.Text
            };

            controlador.Agregar(v);
            MessageBox.Show("Vendedor agregado");

            txt_Apellido.Clear();
            txt_Nombre.Clear();

        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdVendedor.Text) ||
               string.IsNullOrEmpty(txt_IdSucursal.Text))
            {
                MessageBox.Show("Por favor, Seleccione un vendedor y una sucursal.");
                return;
            }
            int idVendedor = int.Parse(txt_IdVendedor.Text);
            int idSucursal = int.Parse(txt_IdSucursal.Text);

            controlador.AsignarSucursal(idVendedor, idSucursal);
            MessageBox.Show("Sucursal asignada al vendedor");
            txt_IdSucursal.Clear();
             txt_IdVendedor.Clear();
        }

        private void btn_Despedir_Click(object sender, EventArgs e)
        {
            int idVendedor = int.Parse(txt_IdVendedor.Text);

            controlador.Despedir(idVendedor);
            MessageBox.Show("Vendedor despedido");
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
