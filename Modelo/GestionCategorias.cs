using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class GestionCategorias
    {
        private static GestionCategorias instancia;
        public static GestionCategorias ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionCategorias();
            }
            return instancia;
        }

        public List<Categoria> ListarCategorias()
        {
            using (var context = new Context())
            {
                return context.Categorias.ToList();
            }
        }

        public void ObtenerCategoriaPorID(int id)
        {
            using (var context = new Context())
            {
                var categoria = context.Categorias.Find(id);
            }
        }
        public void AgregarCategoria(Categoria c)
        {
            using (var context = new Context())
            {
                context.Categorias.Add(c);
                context.SaveChanges();
            }
        }
        public void AsignarCategoria(int idProducto, int idCategoria)
        {
            using (var db = new Context())
            {
                var producto = db.Productos.Find(idProducto);
                if (producto != null)
                {
                    producto.Categoria = idCategoria;
                    db.SaveChanges();
                }
            }
        }
    }
}
