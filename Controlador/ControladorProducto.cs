using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorProducto
    {
        private static ControladorProducto instancia;

        public static ControladorProducto ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorProducto();
            }
            return instancia;
        }

        private readonly GestionProductos gestion = GestionProductos.ObtenerInstancia();

        public List<Producto> Listar() => gestion.ListarProductos();
        public void Agregar(Producto p) => gestion.AgregarProducto(p);
        public void Modificar(Producto p) => gestion.ModificarProducto(p);
        public void Eliminar(int id) => gestion.EliminarProducto(id);
        public List<Producto> BuscarPorSucursal(string sucursal) => gestion.ListarProductos().Where(p => p.Sucursal == sucursal).ToList();



    }
}
