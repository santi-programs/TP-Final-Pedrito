using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MetodoPago
    {
        public string Tipo { get; set; }
        public double Monto { get; set; }
        public string Detalles { get; set; }
        public int IdMetodo { get; set; }


        public MetodoPago(string tipo, double monto, string detalles, int idMetodo)
        {
            Tipo = tipo;
            Monto = monto;
            Detalles = detalles;
            IdMetodo = idMetodo;

        }
    }
}
