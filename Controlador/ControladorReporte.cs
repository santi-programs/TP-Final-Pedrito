using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorReporte
    {
        private static ControladorReporte instancia;

        public static ControladorReporte ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorReporte();
            }
            return instancia;
        }
        private readonly GestionReporte gestion = GestionReporte.ObtenerInstancia();

        public List<ReporteConsulta> ObtenerDatosBase() => gestion.ObtenerDatosBase();
        public object VentasPorSucursal(List<ReporteConsulta> datos) => gestion.ObtenerVentasPorSucursal(datos);
        public object VentasPorVendedor(List<ReporteConsulta> datos) => gestion.ObtenerVentasPorVendedor(datos);
        public object VentasPorProducto(List<ReporteConsulta> datos) => gestion.ObtenerVentasPorProducto(datos);
        public object VentasPorFecha(List<ReporteConsulta> datos) => gestion.ObtenerVentasPorFecha(datos);
        public object ProdMasVendido() => gestion.ProductoMasVendido();
        public string EstadoDeCuenta(int idBuscado) => gestion.EstadoDeCuentaCliente(idBuscado);
    }
}
