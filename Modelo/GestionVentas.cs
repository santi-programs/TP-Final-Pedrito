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
            try
            {
                using (var context = new Context())
                {
                    context.Venta.Add(v);
                    var producto = context.Producto.Find(v.ProductoID);

                    context.ReporteConsulta.Add(new ReporteConsulta
                    {
                        Fecha = v.Fecha,
                        Producto = producto.Nombre,
                        Sucursal = producto.Sucursal,
                        VendedorID = v.VendedorID,
                        Monto = v.Monto
                    });
                    context.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
              
                throw new Exception("Error al guardar la venta: " + ex.InnerException?.Message, ex);
            }
        }

        public void ModificarVenta(Venta v)
        {
            using (var context = new Context())
            {
                var productoExiste = context.Producto.Any(p => p.ProductoID == v.ProductoID);
                var clienteExiste = context.Cliente.Any(c => c.ClienteID == v.ClienteID);
                var vendedorExiste = context.Vendedor.Any(ve => ve.VendedorID == v.VendedorID);

                if (!productoExiste)
                    throw new Exception("El producto seleccionado no existe");

                if (!clienteExiste)
                    throw new Exception("El cliente seleccionado no existe");

                if (!vendedorExiste)
                    throw new Exception("El vendedor seleccionado no existe");

                context.Venta.Update(v);

                var reporte = context.ReporteConsulta
                    .FirstOrDefault(r => r.ReporteConsultaID == v.VentaID);

                if (reporte != null)
                {
                    var producto = context.Producto.Find(v.ProductoID);

                    reporte.Fecha = v.Fecha;
                    reporte.Producto = producto.Nombre;
                    reporte.Sucursal = producto.Sucursal;
                    reporte.VendedorID = v.VendedorID;
                    reporte.Monto = v.Monto;
                }

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

        public string ObtenerDetalleVentaConDescuento(int idventa)
        {
            using (var context = new Context())
            {
                var venta = context.Venta
                    .Include(v => v.ClienteRelacion)
                    .FirstOrDefault(v => v.VentaID == idventa);

                if (venta == null)
                    return "Venta no encontrada";

                double porcentaje = venta.ClienteRelacion.MinoristaMayorista ? 0.20 : 0.0;
                double descuento = venta.Monto * porcentaje;
                double totalFinal = venta.Monto - descuento;

                return $"Monto original: ${venta.Monto}\n" +
                       $"Descuento aplicado: {porcentaje * 100}%\n" +
                       $"Cálculo: {venta.Monto} - {descuento} = {totalFinal}\n" +
                       $"Total final: ${totalFinal}";
            }
        }

        public string ActualizarInventario(int idventa)
        {

            using (var context = new Context())
            {
                var venta = context.Venta.Find(idventa);

                if (venta == null)
                    return "Venta no encontrada";

                var producto = context.Producto.Find(venta.ProductoID);

                if (producto == null)
                    return "Producto no encontrado";

                int stockAnterior = producto.Stock;
                producto.Stock -= venta.Cantidad;

                context.SaveChanges();

                return $"Stock anterior: {stockAnterior}\n" +
                       $"Cantidad vendida: {venta.Cantidad}\n" +
                       $"Nuevo stock: {producto.Stock}";
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
