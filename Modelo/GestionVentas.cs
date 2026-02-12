using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return context.Venta.ToList();
            }
        }   

        public void ObtenerVentaPorID(int id)
        {
            using (var context = new Context())
            {
                var venta = context.Venta.Find(id);
            }
        }
        public void AgregarVenta(Venta v)
        {
            using (var context = new Context())
            {
                context.Venta.Add(v); // problema
                context.SaveChanges();
            }
        }
        public void ModificarVenta(Venta v)
        {
            using (var context = new Context())
            {
                context.Venta.Update(v);
                context.SaveChanges();
            }
        }
        public void EliminarVenta(int id)
        {
            using (var context = new Context())
            {
                var venta = context.Venta.Find(id);
                if (venta != null)
                {
                    context.Venta.Remove(venta);
                    context.SaveChanges();
                }
            }
        }

        public object ObtenerDetalleVentaConDescuento(int idventa)
        {
            using (var context = new Context())
            {
                var ventaInfo = context.Venta
                    .Where(v => v.VentaID == idventa)
                    .Select(v => new
                    {
                        v.VentaID,
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
                var venta = context.Venta.Find(idventa);
                var producto = context.Producto.Find(idproducto);


                int StockActualizado = producto.Stock - venta.Cantidad;
                return StockActualizado;
            }

        }

        public string ValidarPago(int idCliente, double montoAPagar, string TipoPago, int idventa)
        {

            using (var context = new Context())
            {
                var cliente = context.Cliente.Find(idCliente);
                var venta = context.Venta.Find(idventa);
                if (cliente == null) return "Cliente no encontrado";

                double DescuentoAplicado = venta.ClienteRelacion.MinoristaMayorista ? venta.Monto * 0.80 : venta.Monto;

                bool exito = ProcesarPago(id, monto, tipo, descuento);


                return exito ? "Pago procesado con éxito" : "Error al procesar";


            }

        }


        public bool ProcesarPago(int id, double monto, string tipo, double descuento)
        {
            Venta venta = new Venta { Monto = monto };
            if (monto <= 0) return false;

            using (var context = new Context())
            {
                MetodoPago pago = new MetodoPago(id, tipo, descuento );
                context.MetodosPago.Add(pago);
                int filasAfectadas = context.SaveChanges();
                return filasAfectadas > 0;
            }
        }

        public string CrearFactura(int idVenta)
        {
            using (var context = new Context())
            {
                // Importante: .Include para traer los datos del cliente
                var venta = context.Venta
                    .Include(v => v.ClienteRelacion)
                    .FirstOrDefault(v => v.VentaID == idVenta);

                if (venta == null) return "Venta no encontrada";

                return "==========================================\n" +
                       "           FACTURA DE VENTA               \n" +
                       "==========================================\n" +
                       $"ID Venta: {venta.VentaID}\n" +
                       $"Fecha:    {venta.Fecha:dd/MM/yyyy}\n" +
                       "------------------------------------------\n" +
                       $"Cliente:  {venta.ClienteRelacion.Nombre} {venta.ClienteRelacion.Apellido}\n" +
                       $"Monto:    ${venta.Monto:N2}\n" +
                       "==========================================\n" +
                       "        ¡Gracias por su compra!           ";
            }
        } 


    }
}
