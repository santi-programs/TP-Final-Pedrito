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
    public partial class VistaProducto : Form
    {
        private ControladorProducto controlador;
        public VistaProducto()
        {
            controlador = new ControladorProducto();
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombre.Text) ||
               string.IsNullOrEmpty(txt_Descripcion.Text) ||
               string.IsNullOrEmpty(txt_Precio.Text) ||
               string.IsNullOrEmpty(txt_Stock.Text) ||
               string.IsNullOrEmpty(txt_Sucursal.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para modificar el producto.");
                return;
            }
            Producto p = new Producto()
            {
                Nombre = txt_Nombre.Text,
                Descripcion = txt_Descripcion.Text,
                Precio = double.Parse(txt_Precio.Text),
                Stock = int.Parse(txt_Stock.Text),
                Sucursal = txt_Sucursal.Text,
            };

            controlador.Agregar(p);
            MessageBox.Show("Producto agregado");

            txt_Descripcion.Clear();
                txt_Nombre.Clear();
                txt_Precio.Clear();
                txt_Stock.Clear();
                txt_Sucursal.Clear();

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del producto a modificar.");
                return;
            }
            if (!int.TryParse(txt_ID.Text, out int id))
            {
                MessageBox.Show("ID inválido. Por favor, ingrese un número entero.");
                return;
            }
            if (string.IsNullOrEmpty(txt_Nombre.Text) ||
                string.IsNullOrEmpty(txt_Descripcion.Text) ||
                string.IsNullOrEmpty(txt_Precio.Text) ||
                string.IsNullOrEmpty(txt_Stock.Text) ||
                string.IsNullOrEmpty(txt_Sucursal.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para modificar el producto.");
                return;
            }
            Producto p = new Producto()
            {
                ProductoID = int.Parse(txt_ID.Text),
                Nombre = txt_Nombre.Text,
                Descripcion = txt_Descripcion.Text,
                Precio = double.Parse(txt_Precio.Text),
                Stock = int.Parse(txt_Stock.Text),
                Sucursal = txt_Sucursal.Text,
            };

            controlador.Modificar(p);
            MessageBox.Show("Producto modificado");

            txt_Descripcion.Clear();
            txt_Nombre.Clear();
            txt_Precio.Clear();
            txt_Stock.Clear();
            txt_Sucursal.Clear();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txt_ID.Text);
            controlador.Eliminar(id);
            MessageBox.Show("Producto eliminado");
        }

        private void btn_BuscarPorSucursal_Click(object sender, EventArgs e)
        {

            string sucursal = txt_Sucursal.Text;
            var productos = controlador.BuscarPorSucursal(sucursal);
            StringBuilder sb = new StringBuilder();
            foreach (var producto in productos)
            {
                sb.AppendLine($"ID: {producto.ProductoID}," +
                    $" Nombre: {producto.Nombre}," +
                    $" Precio: {producto.Precio}," +
                    $" Stock: {producto.Stock}," +
                    $" Sucursal: {producto.Sucursal}");
            }
            MessageBox.Show(sb.ToString());

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VistaCategoria_Click(object sender, EventArgs e)
        {
            
            VistaCategoria formCategoria = new VistaCategoria();
            formCategoria.Show();
        
        }

    }
}
