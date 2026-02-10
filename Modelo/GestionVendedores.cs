using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Modelo
{
    public class GestionVendedores
    {
        private static GestionVendedores instancia;
        public static GestionVendedores ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionVendedores();
            }
            return instancia;

        }

        public List<Vendedor> ListarVendedores()
        {
            using (var context = new Context())
            {
                return context.Vendedor.ToList();
            }
        }
        public void ObtenerVendedorPorID(int id)
        {
            using (var context = new Context())
            {
                var vendedor = context.Vendedor.Find(id);
            }
        }

        public void AgregarVendedor(Vendedor v)
        {
            using (var context = new Context())
            {
                context.Vendedor.Add(v);
                context.SaveChanges();
            }
        }
        public bool AsignarSucursalAVendedor(int idVendedor, int idSucursal)
        {
            using (var context = new Context())
            {
                var vendedor = context.Vendedor.Find(idVendedor);
                var sucursal = context.Sucursal.Find(idSucursal);
                if (vendedor != null && sucursal != null)
                {
                    vendedor.SucursalID = idSucursal;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public void DespedirVendedor(int idVendedor)
        {
            using (var context = new Context())
            {
                var vendedor = context.Vendedor.Find(idVendedor);
                if (vendedor != null)
                {
                    context.Vendedor.Remove(vendedor);
                    context.SaveChanges();
                }
            }
        }
    }  
}
