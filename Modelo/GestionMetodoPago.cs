using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class GestionMetodoPago
    {
        // Implementación del patrón Singleton
        private static GestionMetodoPago instancia;
        public static GestionMetodoPago ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestionMetodoPago();
            }
            return instancia;
        }


        public List<MetodoPago> ListarMetodo()
        {
            return new List<MetodoPago>
            {
                new MetodoPago(1, "Efectivo", 0.10),          // 10% descuento
                new MetodoPago(2, "Transferencia", 0.05),     // 5% descuento
                new MetodoPago(3, "Tarjeta de Crédito", -0.15), // 15% recargo
                new MetodoPago(4, "Tarjeta de Débito", 0.00)  // sin descuento
            };
        }



        public double CalcularMontoFinal(double montoVenta)
        {
            MetodoPago metodoPago = new MetodoPago();
            return montoVenta * (1 - metodoPago.PorcentajeDescuento);
        }

        public MetodoPago MostrarPorId(int id)
        {
            switch (id)
            {
                case 1:
                    return new MetodoPago(1, "Efectivo", 0.10); // 10% descuento

                case 2:
                    return new MetodoPago(2, "Transferencia", 0.05); // 5% descuento

                case 3:
                    return new MetodoPago(3, "Tarjeta de Crédito", -0.15); // 15% recargo

                case 4:
                    return new MetodoPago(4, "Tarjeta de Débito", 0.00); // sin descuento

                default:
                    throw new ArgumentException("Método de pago no válido.");
            }
        }
    }
}
/*
 double totalVenta = 10000;

MetodoPago metodo = MetodoPago.CrearPorId(1); // Efectivo

double montoFinal = metodo.CalcularMontoFinal(totalVenta);

Console.WriteLine(montoFinal); // 9000

 */