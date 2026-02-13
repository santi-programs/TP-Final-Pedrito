using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Venta
    {
        public int VentaID { get; set; }
        public int ProductoID { get; set; }
        public int ClienteID { get; set; } 
        public string metodoPago { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }

        [ForeignKey("ClienteID")]  
        public virtual Cliente ClienteRelacion { get; set; }

        [ForeignKey("ProductoID")]
        public virtual Producto ProductoRelacion { get; set; }

        public Venta() { }

        public Venta(int idVenta, int idProducto, int idCliente, string Mpago, double monto, int cantidad)
        {
            VentaID = idVenta;
            ProductoID = idProducto;
            ClienteID = idCliente;  // ⭐ AGREGAR ESTO
            metodoPago = Mpago;
            Monto = monto;
            Cantidad = cantidad;
        }
    }
}