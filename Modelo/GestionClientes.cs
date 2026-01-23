using Entidades;
using Microsoft.EntityFrameworkCore;
namespace Modelo
{
    public class GestionClientes
    {
        // Implementación del patrón Singleton
        private static GestionClientes instancia;
        public static GestionClientes ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionClientes();
            }
            return instancia;
        }
        //Aca utilize la Base de Datos para haceer las operaciones CRUD

        public List<Cliente> ListarCliente()
        {
            using (var context = new Context())
            {
                return context.Clientes.ToList();
            }
        }

        public void ObtenerClientePorID(int id)
        {
            using (var context = new Context())
            {
                var cliente = context.Clientes.Find(id);
            }
        }
        public void AgregarCliente(Cliente c)
        {
            using (var context = new Context())
            {
                context.Clientes.Add(c);
                context.SaveChanges();
            }
        }

        public void ModificarCliente(Cliente c)
        {
            using (var context = new Context())
            {
                context.Clientes.Update(c);
                context.SaveChanges();
            }
        }

        public void EliminarCliente(int id)
        {
            using (var context = new Context())
            { 
                var cliente = context.Clientes.Find(id);
                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }
            }
        }

        //Descuentos para clientes

        private const decimal descuentoMayorista = 0.20m;
        private const decimal descuentoMinorista = 0.00m;

        public decimal CalcularDescuento(int idcliente, decimal precioBase)
        {
            using (var db = new Context())
            {
                var cliente = db.Clientes.Find(idcliente);
                if (cliente == null) return precioBase;

                decimal porcentajeAplicado = cliente.MinoristaMayorista ? descuentoMayorista : descuentoMinorista;
                decimal descuento = precioBase * porcentajeAplicado;
                return precioBase - descuento;
            }
        }
        // Para obtener el historial de compras de un cliente 
        public object ObtenerHistorialCompras(int idCliente)
        {
            using (var context = new Context())
            {
                var cliente = context.Clientes
                    .Include(c => c.ventas)
                    .FirstOrDefault(c => c.IDCliente == idCliente);

                if (cliente == null) return "Cliente no encontrado";

                decimal descuento = cliente.MinoristaMayorista ? descuentoMayorista : descuentoMinorista;

                return new
                {
                    Cliente = $"{cliente.Nombre} {cliente.Apellido}",
                    Tipo = cliente.MinoristaMayorista ? "Mayorista" : "Minorista",
                    Compras = cliente.ventas.Select(v => new
                    {
                        v.IdVenta,
                        v.Monto,
                        MontoConDescuento = v.Monto * (1 - descuento)
                    }).ToList()
                };
            }
        }

    }
}
