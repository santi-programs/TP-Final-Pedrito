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
                return context.Cliente.ToList();
            }
        }

        public void ObtenerClientePorID(int id)
        {
            using (var context = new Context())
            {
                var cliente = context.Cliente.Find(id);
            }
        }
        public void AgregarCliente(Cliente c)
        {
            using (var context = new Context())
            {
                context.Cliente.Add(c);
                context.SaveChanges();
            }
        }

        public void ModificarCliente(Cliente c)
        {
            using (var context = new Context())
            {
                context.Cliente.Update(c);
                context.SaveChanges();
            }
        }

        public void EliminarCliente(int id)
        {
            using (var context = new Context())
            { 
                var cliente = context.Cliente.Find(id);
                if (cliente != null)
                {
                    context.Cliente.Remove(cliente);
                    context.SaveChanges();
                }
            }
        }

        //Descuentos para clientes

        private const double descuentoMayorista = 0.20;
        private const double descuentoMinorista = 0.00;

        public double CalcularDescuento(int idcliente, double precioBase)
        {
            using (var db = new Context())
            {
                var cliente = db.Cliente.Find(idcliente);
                if (cliente == null) return precioBase;

                double porcentajeAplicado = cliente.MinoristaMayorista ? descuentoMayorista : descuentoMinorista;
                double descuento = precioBase * porcentajeAplicado;
                return precioBase - descuento;
            }
        }
        // Para obtener el historial de compras de un cliente 
        public object ObtenerHistorialCompras(int idCliente)
        {
            using (var context = new Context())
            {
                var cliente = context.Cliente
                    .Include(c => c.ventas)
                    .FirstOrDefault(c => c.ClienteID == idCliente);

                if (cliente == null) return "Cliente no encontrado";

                double descuento = cliente.MinoristaMayorista ? descuentoMayorista : descuentoMinorista;

                return new
                {
                    Cliente = $"{cliente.Nombre} {cliente.Apellido}",
                    Tipo = cliente.MinoristaMayorista ? "Mayorista" : "Minorista",
                    Compras = cliente.ventas.Select(v => new
                    {
                        v.VentaID,
                        v.Monto,
                        MontoConDescuento = v.Monto * (1 - descuento)
                    }).ToList()
                };
            }
        }

    }
}
