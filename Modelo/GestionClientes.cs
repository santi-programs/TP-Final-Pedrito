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
        public string ObtenerHistorialCompras(int idCliente)
        {
            using (var context = new Context())
            {
                var cliente = context.Cliente
                    .Include(c => c.ventas)
                    .FirstOrDefault(c => c.ClienteID == idCliente);

                if (cliente == null)
                    return "Cliente no encontrado";

                double descuento = cliente.MinoristaMayorista ? 0.20 : 0.00;

                string mensaje = "";
                mensaje += "====================================\n";
                mensaje += "        HISTORIAL DE COMPRAS        \n";
                mensaje += "====================================\n";
                mensaje += $"Cliente: {cliente.Nombre} {cliente.Apellido}\n";
                mensaje += $"Tipo: {(cliente.MinoristaMayorista ? "Mayorista" : "Minorista")}\n";
                mensaje += "------------------------------------\n";

                foreach (var v in cliente.ventas)
                {
                    double montoConDesc = v.Monto * (1 - descuento);

                    mensaje += $"Venta ID: {v.VentaID}\n";
                    mensaje += $"Monto Original: ${v.Monto:N2}\n";
                    mensaje += $"Monto con Descuento: ${montoConDesc:N2}\n";
                    mensaje += "------------------------------------\n";
                }

                return mensaje;
            }
        }

    }
}
