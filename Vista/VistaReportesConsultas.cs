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
    public partial class VistaReportesConsultas : Form
    {
        private ControladorReporte controlador;
        public enum TipoReporte
        {
            PorSucursal,
            PorVendedor,
            PorProducto,
            PorFecha
        }
        public VistaReportesConsultas()
        {

            controlador = new ControladorReporte();
            InitializeComponent();
        }

        private void VistaReportesConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btn_VentasSucursal_Click(object sender, EventArgs e)
        {
            var datos = controlador.ObtenerDatosBase();

            var vista = new VistaReporteVentas(datos, TipoReporte.PorSucursal);
            vista.ShowDialog();
        }

        private void btn_VentasVendedor_Click(object sender, EventArgs e)
        {
            var datos = controlador.ObtenerDatosBase();

            var vista = new VistaReporteVentas(datos, TipoReporte.PorVendedor);
            vista.ShowDialog();
        }

        private void btn_VentasProducto_Click(object sender, EventArgs e)
        {
            var datos = controlador.ObtenerDatosBase();

            var vista = new VistaReporteVentas(datos, TipoReporte.PorProducto);
            vista.ShowDialog();
        }

        private void btn_VentasFecha_Click(object sender, EventArgs e)
        {
            var datos = controlador.ObtenerDatosBase();

            var vista = new VistaReporteVentas(datos, TipoReporte.PorFecha);
            vista.ShowDialog();
        }

        private void btn_MasVendido_Click(object sender, EventArgs e)
        {
            var resultado = controlador.ProdMasVendido();

            MessageBox.Show(resultado.ToString());

        }

        private void btn_EstadoCuenta_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txt_ID.Text, out id))
            {
                string resultado = controlador.EstadoDeCuenta(id);
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
