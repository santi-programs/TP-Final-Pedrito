using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;

namespace Controlador
{
    public class ControladorMetodoPago
    {
        private static ControladorMetodoPago instancia;

        public static ControladorMetodoPago ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorMetodoPago();
            }
            return instancia;
        }

        private readonly GestionMetodoPago gestion = GestionMetodoPago.ObtenerInstancia();

        public double MontoFinal(double montoVenta) => gestion.CalcularMontoFinal(montoVenta);
        public MetodoPago Mostrar(int id) => gestion.MostrarPorId(id);
        public List<MetodoPago> Listar()
        {
            return gestion.ListarMetodo();
        }
    }
}
