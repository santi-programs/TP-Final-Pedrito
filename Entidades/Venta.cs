using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public int VentaID { get; set; }
        public int ProductoID { get; set; }
        public string metodoPago { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public virtual Cliente ClienteRelacion { get; set; }
        public virtual Producto ProductoRelacion { get; set; }

        public Venta() { }


        public Venta(int idVenta, int idProducto, string Mpago, double monto, int cantidad)
        {
            VentaID = idVenta;
            ProductoID = idProducto;
            metodoPago = Mpago;
            Monto = monto;
            Cantidad = cantidad;
        }
    }
}
