using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Modelo
{
    public class GestionReporte
    {

        public GestionReporte() { }
        public static GestionReporte instancia;
        public static GestionReporte ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionReporte();
            }
            return instancia;
        }

        private readonly GestionVentas gestionVentas = new GestionVentas();
        public void GenerarReporteVentas()
        {
            // Lógica para generar un reporte de ventas 
        }
        public void GenerarReporteInventario()
        {
            // Lógica para generar un reporte de inventario
        }

        public void CuentaDeClientes()
        {
            // Lógica para generar un reporte de cuenta de clientes
        }

        // Falta Productos mas vendidos
    }

}