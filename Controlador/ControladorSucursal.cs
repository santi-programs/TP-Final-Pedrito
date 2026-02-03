using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorSucursal
    {
        private static ControladorSucursal instancia;

        public static ControladorSucursal ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorSucursal();
            }
            return instancia;
        }
        private readonly GestionSucursal gestion = GestionSucursal.ObtenerInstancia();

        public void Agregar(Sucursal s) => gestion.AgregarSucursal(s);
        public void Modificar(Sucursal s) => gestion.ModificarSucursal(s);
        public void Eliminar(int id) => gestion.EliminarSucursal(id);


    }
}
