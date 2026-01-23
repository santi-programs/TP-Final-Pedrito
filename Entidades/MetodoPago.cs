using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MetodoPago
    {
        private string Tipo { get; set; }
        private double Monto { get; set; }
        private string Detalles { get; set; }

        public MetodoPago(string tipo, double monto, string detalles)
        {
            Tipo = tipo;
            Monto = monto;
            Detalles = detalles;
        }
    }
}
