using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Modelo
{
    public class GestionSucursal
    {
        public GestionSucursal() { }
        public static GestionSucursal instancia;
        public static GestionSucursal ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionSucursal();
            }
            return instancia;
        }

        public List<Sucursal> ListarSucursales()
        {
            using (var context = new Context())
            {
                return context.Sucursales.ToList();
            }
        }

        //Aca utilize la Base de Datos para haceer las operaciones CRUD
        public void ObtenerSucursalPorID(int id)
        {
            using (var context = new Context())
            {
                var sucursal = context.Sucursales.Find(id);
            }
        }

        public void AgregarSucursal(Sucursal s)
        {
            using (var context = new Context())
            {
                context.Sucursales.Add(s);
                context.SaveChanges();
            }
        }

        public void ModificarSucursal(Sucursal s)
        {
            using(var context = new Context())
            {
                context.Sucursales.Update(s);
                context.SaveChanges();
            }
        }

        public void EliminarSucursal(int id)
        {
            using(var context = new Context())
            {
                var sucursal = context.Sucursales.Find(id);
                if (sucursal != null)
                {
                    context.Sucursales.Remove(sucursal);
                    context.SaveChanges();
                }
            }
        }
    }
}
