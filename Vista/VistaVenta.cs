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


namespace Vista
{
    public partial class VistaVenta : Form
    {
        private ControladorVenta controlador;
        private ControladorMetodoPago listaMetodos;
        public VistaVenta()
        {
            InitializeComponent();
            controlador = new ControladorVenta();
            listaMetodos = new ControladorMetodoPago();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            // Validaciones
            if (cbo_Producto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            if (!int.TryParse(txt_Cantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            if (!double.TryParse(txt_Monto.Text, out double monto))
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            // Crear venta
            Venta v = new Venta
            {
                ProductoID = (int)cbo_Producto.SelectedValue,  // ✅ Obtiene el ID (no el nombre)
                Cantidad = cantidad,
                Monto = monto,
                metodoPago = cbo_MetodoPago.Text,
                Fecha = dtp_Fecha.Value,
                ClienteID = (int)cbo_Cliente.SelectedValue
            };



            try
            {
                controlador.Agregar(v);
                MessageBox.Show("Venta agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar venta: " + ex.Message);

                // Para debug más completo:
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private void btn_Descuento_Click(object sender, EventArgs e)
        {

        }

        private void btn_Factura_Click(object sender, EventArgs e)
        {
            int idVenta = int.Parse(txt_ID.Text);

            string contenido = controlador.Factura(idVenta);

            VistaFactura pantallaFactura = new VistaFactura(contenido);
            pantallaFactura.ShowDialog();

        }



        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cbo_Cliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            if (cbo_Producto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            if (!int.TryParse(txt_Cantidad.Text, out int cantidad))
            {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            if (!double.TryParse(txt_Monto.Text, out double monto))
            {
                MessageBox.Show("Monto inválido");
                return;
            }

            // CREAR objeto venta con el ID existente
            Venta v = new Venta
            {
                VentaID = int.Parse(txt_ID.Text), // ⭐ IMPORTANTE: necesitas el ID de la venta a modificar
                ProductoID = (int)cbo_Producto.SelectedValue,
                ClienteID = (int)cbo_Cliente.SelectedValue,
                Cantidad = cantidad,
                Monto = monto,
                metodoPago = cbo_MetodoPago.Text,
                Fecha = dtp_Fecha.Value
            };

            try
            {
                controlador.Modificar(v);
                MessageBox.Show("Venta modificada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            controlador.Eliminar(id);
            MessageBox.Show("Venta eliminada");
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaVenta_Load(object sender, EventArgs e)
        {
            var controlador = ControladorMetodoPago.ObtenerInstancia();
            var productos = ControladorProducto.ObtenerInstancia();
            var clientes = ControladorCliente.ObtenerInstancia();

            cbo_MetodoPago.DataSource = controlador.Listar();  // Ahora devuelve los 4 métodos
            cbo_MetodoPago.DisplayMember = "Display";          // Muestra "1 - Efectivo", etc.
            cbo_MetodoPago.ValueMember = "MetodoPagoID";       // ID interno

            cbo_Producto.DataSource = productos.Listar();  
            cbo_Producto.DisplayMember = "Nombre";          
            cbo_Producto.ValueMember = "ProductoID";

            cbo_Cliente.DataSource = clientes.Listar();  
            cbo_Cliente.DisplayMember = "Nombre";          
            cbo_Cliente.ValueMember = "ClienteID";
        }

       
    }
}
