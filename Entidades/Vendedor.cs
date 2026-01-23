using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public int IDVendedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IDSucursal { get; set; }
        public Vendedor(int idVendedor, string nombre, string apellido, int idSucursal)
        {
            IDVendedor = idVendedor;
            Nombre = nombre;
            Apellido = apellido;
            IDSucursal = idSucursal;
        }
    }
}
