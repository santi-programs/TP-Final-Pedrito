using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private int Id { get; set; }
        private int IDCliente { get; set; }
        private int Cliente { get; set; }

        public Venta (int id, int idCliente, int cliente)
        {
            Id = id;
            IDCliente = idCliente;
            Cliente = cliente;
        }
    }
}
