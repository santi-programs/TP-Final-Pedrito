using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IDProducto { get; set; }
        public string metodoPago { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public virtual Cliente ClienteRelacion { get; set; }
        public virtual Producto ProductoRelacion { get; set; }
        public int Cantidad { get; set; }

        public Venta(int idVenta, int idProducto, string Mpago, double monto, int cantidad)
        {
            IdVenta = idVenta;
            IDProducto = idProducto;
            metodoPago = Mpago;
            Monto = monto;
            Cantidad = cantidad;
        }
    }
}
