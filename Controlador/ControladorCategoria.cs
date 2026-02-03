using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorCategoria
    {
        private static ControladorCategoria instancia;

        public static ControladorCategoria ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorCategoria();
            }
            return instancia;
        }
        private readonly GestionCategorias gestion = GestionCategorias.ObtenerInstancia();

        public void Agregar(Categoria c) => gestion.AgregarCategoria(c);
        public void Asignar(int idProducto, int idCategoria) => gestion.AsignarCategoria(idProducto, idCategoria);



    }
}
