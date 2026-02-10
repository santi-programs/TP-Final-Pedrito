using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }

        public Categoria() {       }

        public Categoria(int idCategoria, string nombre)
        {
            CategoriaID = idCategoria;
            Nombre = nombre;
           
        }
    }
}
