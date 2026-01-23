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
        private int IDSucursal { get; set; }
        private string Direccion { get; set; }
        private double Precio { get; set; }
        private int Stock { get; set; }
        
        public Sucursal(int idSucursal, string direccion, double precio, int stock)
        {
            IDSucursal = idSucursal;
            Direccion = direccion;
            Precio = precio;
            Stock = stock;
        }
    }
}
