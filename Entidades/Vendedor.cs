using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public int VendedorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int SucursalID { get; set; }

        public Vendedor() { }
        public Vendedor(int idVendedor, string nombre, string apellido, int idSucursal)
        {
            VendedorID = idVendedor;
            Nombre = nombre;
            Apellido = apellido;
            SucursalID = idSucursal;
        }
    }
}
