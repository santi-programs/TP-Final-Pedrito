using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class GestionProductos
    {
        public GestionProductos() { }

        public static GestionProductos instancia;
        public static GestionProductos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionProductos();
            }
            return instancia;
        }
        //Aca utilize la Base de Datos para haceer las operaciones CRUD
        public List<Producto> ListarProductos()
        {
            using (var context = new Context())
            {
                return context.Productos.ToList();
            }
        }
        public void ObtenerProductoPorID(int id)
        {
            using (var context = new Context())
            {
                var producto = context.Productos.Find(id);
            }
        }

        public void AgregarProducto(Producto p)
        {
            using (var context = new Context())
            {
                context.Productos.Add(p);
                context.SaveChanges();
            }
        }
        public void ModificarProducto(Producto p)
        {
            using (var context = new Context())
            {
                context.Productos.Update(p);
                context.SaveChanges();
            }
        }
        public void EliminarProducto(int id)
        {
            using (var context = new Context())
            {
                var producto = context.Productos.Find(id);
                if (producto != null)
                {
                    context.Productos.Remove(producto);
                    context.SaveChanges();
                }
            }
        }

        public List<Producto> BuscarProductosPorSucursal(string sucursal)
        {
            using (var context = new Context())
            {
                return context.Productos
                              .Where(p => p.Sucursal.Contains(sucursal))
                              .ToList();
            }
        }

    }
}
