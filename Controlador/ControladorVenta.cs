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

        public void Agregar(Venta v) => gestion.AgregarVenta(v);
        public void Modificar(Venta v) => gestion.ModificarVenta(v);
        public void Eliminar(int id) => gestion.EliminarVenta(id);
        public object DetalleVentaConDescuento(int idventa) => gestion.ObtenerDetalleVentaConDescuento(idventa);
        public int ActualizarInv(int idventa, int idproducto) => gestion.ActualizarInventario(idventa, idproducto);
        public string Validar(int idCliente, double montoAPagar, string TipoPago, int idventa) => gestion.ValidarPago(idCliente, montoAPagar, TipoPago, idventa);
        public bool Procesar(string tipo, double monto, string detalles) => gestion.ProcesarPago(tipo, monto, detalles);
        public string Factura(int idVenta) => gestion.CrearFactura(idVenta);




    }
}
