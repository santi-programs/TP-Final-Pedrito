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
        public int IDCliente { get; set; }
        public int Cliente { get; set; }
        public decimal Monto { get; set; }

        public Venta (int id, int idCliente, int cliente, decimal monto)
        {
            IdVenta = id;
            IDCliente = idCliente;
            Cliente = cliente;
            Monto = monto;
        }
    }
}
