using Modelo;
using Entidades;
namespace Controlador
{
    public class ControladorVenta
    {

        private static ControladorVenta instancia;

        public static ControladorVenta ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorVenta();
            }
            return instancia;
        }

        private readonly GestionVentas gestion = GestionVentas.ObtenerInstancia();

        public List<Venta> Listar() => gestion.ListarVentas();
        public void Agregar(Venta v) => gestion.AgregarVenta(v);
        public void Modificar(Venta v) => gestion.ModificarVenta(v);
        public void Eliminar(int id) => gestion.EliminarVenta(id);
        public string DetalleVentaConDescuento(int idventa) => gestion.ObtenerDetalleVentaConDescuento(idventa);
        public string ActualizarInv(int idventa) => gestion.ActualizarInventario(idventa);
        public string Factura(int idVenta) => gestion.CrearFactura(idVenta);

        

    }
}
