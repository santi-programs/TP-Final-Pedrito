using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorVendedor
    {

        private static ControladorVendedor instancia;

        public static ControladorVendedor ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorVendedor();
            }
            return instancia;
        }

        private readonly GestionVendedores gestion = GestionVendedores.ObtenerInstancia();

        public void Agregar(Vendedor v) => gestion.AgregarVendedor(v);
        public bool AsignarSucursal(int idVendedor, int idSucursal) => gestion.AsignarSucursalAVendedor(idVendedor, idSucursal);
        public void Despedir(int idVendedor) => gestion.DespedirVendedor(idVendedor);



    }
}
