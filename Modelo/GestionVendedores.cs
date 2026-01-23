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
                return context.Vendedores.ToList();
            }
        }
        public void ObtenerVendedorPorID(int id)
        {
            using (var context = new Context())
            {
                var vendedor = context.Vendedores.Find(id);
            }
        }

        public void AgregarVendedor(Vendedor v)
        {
            using (var context = new Context())
            {
                context.Vendedores.Add(v);
                context.SaveChanges();
            }
        }
        public bool AsignarSucursalAVendedor(int idVendedor, int idSucursal)
        {
            using (var context = new Context())
            {
                var vendedor = context.Vendedores.Find(idVendedor);
                var sucursal = context.Sucursales.Find(idSucursal);
                if (vendedor != null && sucursal != null)
                {
                    vendedor.IDSucursal = idSucursal;
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
                var vendedor = context.Vendedores.Find(idVendedor);
                if (vendedor != null)
                {
                    context.Vendedores.Remove(vendedor);
                    context.SaveChanges();
                }
            }
        }
    }  
}
