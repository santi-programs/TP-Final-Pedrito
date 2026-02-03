using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int IDProducto {  get; set; }
        public string Nombre {  get; set; }
        public string Descripcion {  get; set; }
        public int Categoria {  get; set; }
        public double Precio   {  get; set; }
        public int Stock {  get; set; } 

        public string Sucursal { get; set; }    

        public Producto() {     }

        public Producto(int idProducto, string nombre, string descripcion, int categoria, double precio, int stock, string sucursal)
        {
            IDProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Categoria = categoria;
            Precio = precio;
            Stock = stock;
            Sucursal = sucursal;
        }   
    }

}

