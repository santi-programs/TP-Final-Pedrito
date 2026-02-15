using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Modelo
{
    public class GestionReporte
    {

        public GestionReporte() { }
        public static GestionReporte instancia;
        public static GestionReporte ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionReporte();
            }
            return instancia;
        }

        private readonly GestionVentas gestionVentas = new GestionVentas();

        public List<ReporteConsulta> ObtenerDatosBase()
        {
            using (var db = new Context())
            {
                return db.ReporteConsulta.ToList();
            }
        }


        public object ObtenerVentasPorSucursal(List<ReporteConsulta> datos)
        {
            var reporte = datos.GroupBy(d => d.Sucursal.Trim().ToUpper())
                .Select(g => new
                {
                    NombreSucursal = g.Key,
                    TotalVentas = g.Sum(x => x.Monto),
                    CantidadOperaciones = g.Count()
                })
                .ToList();
            return reporte;
        }

        public object ObtenerVentasPorVendedor(List<ReporteConsulta> datos)
        {
            var reporte = datos.GroupBy(d => d.VendedorID)
                .Select(g => new
                {
                    VendedorID = g.Key,
                    TotalVentas = g.Sum(x => x.Monto),
                    CantidadOperaciones = g.Count()
                })
                .ToList();
            return reporte;
        }

        public object ObtenerVentasPorProducto(List<ReporteConsulta> datos)
        {
            var reporte = datos.GroupBy(d => d.Producto.Trim().ToUpper())
                .Select(g => new
                {
                    NombreProducto = g.Key,
                    TotalVentas = g.Sum(x => x.Monto),
                    CantidadOperaciones = g.Count()
                })
                .ToList();
            return reporte;
        }

        public object ObtenerVentasPorFecha(List<ReporteConsulta> datos)
        {
            var reporte = datos.GroupBy(d => d.Fecha.Date)
                .Select(g => new
                {
                    Fecha = g.Key,
                    TotalVentas = g.Sum(x => x.Monto),
                    CantidadOperaciones = g.Count()
                })
                .ToList();
            return reporte;
        }

        public object ProductoMasVendido()
        {
            var ventas = gestionVentas.ListarVentas();

            var resultado = ventas
                .GroupBy(v => v.ProductoID)
                .Select(g => new
                {
                    ProductoID = g.Key,
                    CantidadVendida = g.Count()
                })
                .OrderByDescending(x => x.CantidadVendida)
                .FirstOrDefault();

            return resultado;
        }


        public string EstadoDeCuentaCliente(int idBuscado)
        {
            using (var db = new Context())
            {
                var cliente = db.Cliente.Find(idBuscado);
                if (cliente == null) return "No existe";

                if (cliente.MinoristaMayorista)
                {
                    
                    return $"Cliente Mayorista: {cliente.Nombre} - Saldo preferencial disponible.";
                }
                else
                {
                    
                    return $"Cliente Minorista: {cliente.Nombre} - Pago al contado.";
                }
            }
        }
    }
}
