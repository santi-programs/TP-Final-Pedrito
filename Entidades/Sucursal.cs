using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        public int IDSucursal { get; set; }
        public string Direccion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        
        public Sucursal(int idSucursal, string direccion, double precio, int stock)
        {
            IDSucursal = idSucursal;
            Direccion = direccion;
            Precio = precio;
            Stock = stock;
        }
    }
}
