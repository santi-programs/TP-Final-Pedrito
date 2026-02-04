using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class GestionVentas
    {
        public GestionVentas() { }

        public static GestionVentas instancia;

        public static GestionVentas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionVentas();
            }
            return instancia;
        }
        //Aca utilize la Base de Datos para haceer las operaciones CRUD
        public List<Venta> ListarVentas()
        {
            using (var context = new Context())
            {
                return context.Ventas.ToList();
            }
        }   

        public void ObtenerVentaPorID(int id)
        {
            using (var context = new Context())
            {
                var venta = context.Ventas.Find(id);
            }
        }
        public void AgregarVenta(Venta v)
        {
            using (var context = new Context())
            {
                context.Ventas.Add(v);
                context.SaveChanges();
            }
        }
        public void ModificarVenta(Venta v)
        {
            using (var context = new Context())
            {
                context.Ventas.Update(v);
                context.SaveChanges();
            }
        }
        public void EliminarVenta(int id)
        {
            using (var context = new Context())
            {
                var venta = context.Ventas.Find(id);
                if (venta != null)
                {
                    context.Ventas.Remove(venta);
                    context.SaveChanges();
                }
            }
        }

        public object ObtenerDetalleVentaConDescuento(int idventa)
        {
            using (var context = new Context())
            {
                var ventaInfo = context.Ventas
                    .Where(v => v.IdVenta == idventa)
                    .Select(v => new
                    {
                        v.IdVenta,
                        PrecioOriginal = v.Monto,
                        DescuentoAplicado = v.ClienteRelacion.MinoristaMayorista ? v.Monto * 0.80 : v.Monto,
                        EsMayorista = v.ClienteRelacion.MinoristaMayorista
                    })
                    .FirstOrDefault();
                return ventaInfo;
            }
        }

        public int ActualizarInventario(int idventa, int idproducto)
        {

            using (var context = new Context())
            {
                var venta = context.Ventas.Find(idventa);
                var producto = context.Productos.Find(idproducto);


                int StockActualizado = producto.Stock - venta.Cantidad;
                return StockActualizado;
            }

        }

        public string ValidarPago(int idCliente, double montoAPagar, string TipoPago, int idventa)
        {

            using (var context = new Context())
            {
                var cliente = context.Clientes.Find(idCliente);
                var venta = context.Ventas.Find(idventa);
                if (cliente == null) return "Cliente no encontrado";

                double DescuentoAplicado = venta.ClienteRelacion.MinoristaMayorista ? venta.Monto * 0.80 : venta.Monto;

                bool exito = ProcesarPago(TipoPago, DescuentoAplicado, $"Pago de cliente {cliente.Nombre}");


                return exito ? "Pago procesado con éxito" : "Error al procesar";


            }

        }


        public bool ProcesarPago(string tipo, double monto, string detalles)
        {
            if (monto <= 0) return false;

            using (var context = new Context())
            {
                MetodoPago pago = new MetodoPago(tipo, monto, detalles, 0);
                context.MetodosDePago.Add(pago);
                int filasAfectadas = context.SaveChanges();
                return filasAfectadas > 0;
            }
        }

        public string CrearFactura(int idVenta)
        {
            using (var context = new Context())
            {
                var venta = context.Ventas.Find(idVenta);
                if (venta == null) return "Venta no encontrada";
                string factura = $"Factura de Venta\n" +
                                 $"ID Venta: {venta.IdVenta}\n" +
                                 $"Cliente: {venta.ClienteRelacion.Nombre} {venta.ClienteRelacion.Apellido}\n" +
                                 $"Monto: {venta.Monto}\n" +
                                 $"Fecha: {venta.Fecha}\n";
                return factura;
            }
        } 

        //No se guardaron los métodos en el último push que hiciste

    }
}
