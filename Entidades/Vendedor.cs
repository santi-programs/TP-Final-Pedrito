using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private int IDVendedor { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int IDSucursal { get; set; }
        public Vendedor(int idVendedor, string nombre, string apellido, int idSucursal)
        {
            IDVendedor = idVendedor;
            Nombre = nombre;
            Apellido = apellido;
            IDSucursal = idSucursal;
        }
    }
}
