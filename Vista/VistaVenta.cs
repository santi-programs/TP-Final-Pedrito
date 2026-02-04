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
        public VistaVenta()
        {
            InitializeComponent();
            controlador = new ControladorVenta();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Venta v = new Venta
            {
                metodoPago = cbo_MetodoPago.Text,
                Monto = Convert.ToDouble(txt_Monto.Text),
                Cantidad = Convert.ToInt32(txt_Cantidad.Text),
                Fecha = DateTime.Now
            };

            controlador.Agregar(v);
            MessageBox.Show("Venta agregada");
        }

        private void btn_Descuento_Click(object sender, EventArgs e)
        {

        }

        private void btn_Factura_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            controlador.Factura(id);
            
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Venta v = new Venta
            {
                IdVenta = int.Parse(txt_ID.Text),
                metodoPago = cbo_MetodoPago.Text,
                Monto = Convert.ToDouble(txt_Monto.Text),
                Cantidad = Convert.ToInt32(txt_Cantidad.Text),
                Fecha = DateTime.Now
            };

            controlador.Modificar(v);
            MessageBox.Show("Venta agregada");
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            controlador.Eliminar(id);
            MessageBox.Show("Venta eliminada");             
        }
    }
}
