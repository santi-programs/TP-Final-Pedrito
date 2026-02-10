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

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
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
