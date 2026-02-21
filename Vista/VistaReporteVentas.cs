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
using static Vista.VistaReportesConsultas;

namespace Vista
{
    public partial class VistaReporteVentas : Form
    {
        private List<ReporteConsulta> datos;
        private TipoReporte tipo;
        private ControladorReporte controlador;
        private Venta venta;

        public VistaReporteVentas(List<ReporteConsulta> datos, TipoReporte tipo)
        {
            InitializeComponent();
            this.datos = datos;
            this.tipo = tipo;
            controlador = new ControladorReporte();
            venta = new Venta();
            CargarReporte();
        }
        private void CargarReporte()
        {
            object resultado = null;

            switch (tipo)
            {
                case TipoReporte.PorSucursal:
                    resultado = controlador.VentasPorSucursal(datos);
                    break;

                case TipoReporte.PorVendedor:
                    resultado = controlador.VentasPorVendedor(datos);
                    break;

                case TipoReporte.PorProducto:
                    resultado = controlador.VentasPorProducto(datos);
                    break;

                case TipoReporte.PorFecha:
                    resultado = controlador.VentasPorFecha(datos);
                    break;
            }

            dgv_Reporte.DataSource = null;
            dgv_Reporte.DataSource = resultado;
        }
        private void VistaReporteVentas_Load(object sender, EventArgs e)
        {
            object resultado = null;

            switch (tipo)
            {
                case TipoReporte.PorSucursal:
                    resultado = controlador.VentasPorSucursal(datos);
                    break;

                case TipoReporte.PorVendedor:
                    resultado = controlador.VentasPorVendedor(datos);
                    break;

                case TipoReporte.PorProducto:
                    resultado = controlador.VentasPorProducto(datos);
                    break;

                case TipoReporte.PorFecha:
                    resultado = controlador.VentasPorFecha(datos);
                    break;
            }

            dgv_Reporte.DataSource = resultado;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
