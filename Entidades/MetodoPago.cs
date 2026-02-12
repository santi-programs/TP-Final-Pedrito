using System;

namespace Entidades
{
    public class MetodoPago
    {
        public int MetodoPagoID { get; set; }
        public string Tipo { get; set; }
        public double PorcentajeDescuento { get; set; } 

        public MetodoPago()
        {
        }

        public MetodoPago(int id, string tipo, double porcentajeDescuento)
        {
            MetodoPagoID = id;
            Tipo = tipo;
            PorcentajeDescuento = porcentajeDescuento;
        }

        public double CalcularMontoFinal(double montoVenta)
        {
            return montoVenta * (1 - PorcentajeDescuento);
        }

        public static MetodoPago CrearPorId(int id)
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
