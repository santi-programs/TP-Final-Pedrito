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
        public int VendedorID { get; set; }

        [ForeignKey("ClienteID")]  
        public virtual Cliente ClienteRelacion { get; set; }

        [ForeignKey("ProductoID")]
        public virtual Producto ProductoRelacion { get; set; }

        public Venta() { }

            public Venta(int idVenta, int idProducto, int idCliente, string Mpago, double monto, int cantidad, int vendedorID)
            {
                VentaID = idVenta;
                ProductoID = idProducto;
                ClienteID = idCliente;  
                metodoPago = Mpago;
                Monto = monto;
                Cantidad = cantidad;
                VendedorID = vendedorID;
        }
    }
}