using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class GestionVentas
    {
        public GestionVentas() { }

        public static GestionVentas instancia;

        public static GestionVentas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionVentas();
            }
            return instancia;
        }
        //Aca utilize la Base de Datos para haceer las operaciones CRUD
        public List<Venta> ListarVentas()
        {
            using (var context = new Context())
            {
                return context.Ventas.ToList();
            }
        }   

        public void ObtenerVentaPorID(int id)
        {
            using (var context = new Context())
            {
                var venta = context.Ventas.Find(id);
            }
        }
        public void AgregarVenta(Venta v)
        {
            using (var context = new Context())
            {
                context.Ventas.Add(v);
                context.SaveChanges();
            }
        }
        public void ModificarVenta(Venta v)
        {
            using (var context = new Context())
            {
                context.Ventas.Update(v);
                context.SaveChanges();
            }
        }
        public void EliminarVenta(int id)
        {
            using (var context = new Context())
            {
                var venta = context.Ventas.Find(id);
                if (venta != null)
                {
                    context.Ventas.Remove(venta);
                    context.SaveChanges();
                }
            }
        }

        //No se guardaron los métodos en el último push que hiciste
        
    }
}
