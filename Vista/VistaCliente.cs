using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Entidades;
using Modelo;

namespace Vista
{
    public partial class VistaCliente : Form
    {
        private ControladorCliente controlador;



        public VistaCliente()
        {
            InitializeComponent();
            controlador = new ControladorCliente();




        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombre.Text) ||
               string.IsNullOrEmpty(txt_Apellido.Text) ||
               string.IsNullOrEmpty(txt_DNI.Text) ||
               string.IsNullOrEmpty(txt_Telefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para agregar el cliente.");
                return;
            }
            Cliente c = new Cliente
            {
                Nombre = txt_Nombre.Text,
                Apellido = txt_Apellido.Text,
                DNI = txt_DNI.Text,
                MinoristaMayorista = rb_Mayorista.Checked ? true : false,
                Telefono = txt_Telefono.Text
            };

            controlador.Agregar(c);
            MessageBox.Show("Cliente agregado");

            txt_Apellido.Clear();
            txt_DNI.Clear();
            txt_Nombre.Clear();
            txt_Telefono.Clear();

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text) ||
                string.IsNullOrEmpty(txt_Nombre.Text) ||
                string.IsNullOrEmpty(txt_Apellido.Text) ||
                string.IsNullOrEmpty(txt_DNI.Text) ||
                string.IsNullOrEmpty(txt_Telefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para modificar el cliente.");
                return;
            }
            Cliente c = new Cliente
            {
                ClienteID = int.Parse(txt_ID.Text),
                Nombre = txt_Nombre.Text,
                Apellido = txt_Apellido.Text,
                DNI = txt_DNI.Text,
                MinoristaMayorista = rb_Mayorista.Checked ? true : false,
                Telefono = txt_Telefono.Text
            };

            controlador.Modificar(c);
            MessageBox.Show("Cliente modificado");

            txt_Apellido.Clear();
            txt_DNI.Clear();
            txt_Nombre.Clear();
            txt_Telefono.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            controlador.Eliminar(id);
            MessageBox.Show("Cliente eliminado");
        }

        private void btn_Descuento_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            double precioBase = double.Parse(txt_precio.Text);

            double precioFinal = controlador.Descuento(id, precioBase);

            MessageBox.Show(precioFinal.ToString("0.00"));
        }

        private void btn_Historial_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txt_ID.Text);

            string mensaje = controlador.HistorialCompras(id);

            MessageBox.Show(mensaje);       

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
