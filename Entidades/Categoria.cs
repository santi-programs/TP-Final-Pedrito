using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        private int IDCategoria { get; set; }
        private string Nombre { get; set; }
       
        public Categoria(int idCategoria, string nombre)
        {
            IDCategoria = idCategoria;
            Nombre = nombre;
           
        }
    }
}
