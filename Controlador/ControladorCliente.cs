using Modelo;
using Entidades;
namespace Controlador
{
    public class ControladorCliente
    {
        private static ControladorCliente instancia;

        public static ControladorCliente ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorCliente();
            }
            return instancia;
        }

        private readonly GestionClientes gestion = GestionClientes.ObtenerInstancia();

        public List<Cliente> Listar() => gestion.ListarCliente();
        public void Agregar(Cliente c) => gestion.AgregarCliente(c);
        public void Modificar(Cliente c) => gestion.ModificarCliente(c);
        public void Eliminar(int id) => gestion.EliminarCliente(id);
        public double Descuento(int idcliente, double precioBase) => gestion.CalcularDescuento(idcliente, precioBase);
        public object HistorialCompras(int idCliente) => gestion.ObtenerHistorialCompras(idCliente);


    }
}
