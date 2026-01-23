using Entidades;
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



    }
}
