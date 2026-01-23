using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int IDProducto {  get; set; }
        private string Nombre {  get; set; }
        private string Descripcion {  get; set; }
        private Categoria Categoria {  get; set; }
        private double Precio   {  get; set; }
        private int Stock {  get; set; } 

        public Producto(int idProducto, string nombre, string descripcion, Categoria categoria, double precio, int stock)
        {
            IDProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Categoria = categoria;
            Precio = precio;
            Stock = stock;
        }   
    }

}

