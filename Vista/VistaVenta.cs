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

           
            Venta v = new Venta
            {
                ProductoID = (int)cbo_Producto.SelectedValue,  
                Cantidad = cantidad,
                Monto = monto,
                metodoPago = cbo_MetodoPago.Text,
                Fecha = dtp_Fecha.Value,
                ClienteID = (int)cbo_Cliente.SelectedValue,
                VendedorID= (int)cbo_Vendedor.SelectedValue
            };



            try
            {
                controlador.Agregar(v);
                MessageBox.Show("Venta agregada");

                txt_Cantidad.Clear();
                txt_Monto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar venta: " + ex.Message);

                
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private void btn_Descuento_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ID.Text, out int id))
            {
                string resultado = controlador.DetalleVentaConDescuento(id);
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
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

           
            Venta v = new Venta
            {
                VentaID = int.Parse(txt_ID.Text), 
                ProductoID = (int)cbo_Producto.SelectedValue,
                ClienteID = (int)cbo_Cliente.SelectedValue,
                Cantidad = cantidad,
                Monto = monto,
                metodoPago = cbo_MetodoPago.Text,
                Fecha = dtp_Fecha.Value,
                VendedorID = (int)cbo_Vendedor.SelectedValue
            };

            try
            {
                controlador.Modificar(v);
                MessageBox.Show("Venta modificada correctamente");
                txt_Cantidad.Clear();
                txt_Monto.Clear();

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
            var vendedor = ControladorVendedor.ObtenerInstancia();

            cbo_MetodoPago.DataSource = controlador.Listar();  
            cbo_MetodoPago.DisplayMember = "Display";          
            cbo_MetodoPago.ValueMember = "MetodoPagoID";       

            cbo_Producto.DataSource = productos.Listar();
            cbo_Producto.DisplayMember = "Nombre";
            cbo_Producto.ValueMember = "ProductoID";

            cbo_Cliente.DataSource = clientes.Listar();
            cbo_Cliente.DisplayMember = "Nombre";
            cbo_Cliente.ValueMember = "ClienteID";

            cbo_Vendedor.DataSource = vendedor.Listar();
            cbo_Vendedor.DisplayMember = "Nombre";  
            cbo_Vendedor.ValueMember = "VendedorID";
        }

        private void btn_ActualizarStock_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ID.Text, out int id))
            {
                string resultado = controlador.ActualizarInv(id);
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }
    }
}
