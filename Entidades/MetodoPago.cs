using System;

namespace Entidades
{
    public class MetodoPago
    {
        public int MetodoPagoID { get; set; }
        public string Tipo { get; set; }
        public double PorcentajeDescuento { get; set; } // 0.10 = 10%

        // Nueva propiedad para mostrar ID - Tipo en el ComboBox
        public string Display => $"{MetodoPagoID} - {Tipo}";

        public MetodoPago()
        {
        }

        public MetodoPago(int id, string tipo, double porcentajeDescuento)
        {
            MetodoPagoID = id;
            Tipo = tipo;
            PorcentajeDescuento = porcentajeDescuento;
        }
    }
}