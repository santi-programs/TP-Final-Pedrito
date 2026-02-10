using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MetodoPago
    {
        public int MetodoPagoID { get; set; }
        public string Tipo { get; set; }
        public double Monto { get; set; }
        public string Detalles { get; set; }
        

        public MetodoPago()
        {
        }
        public MetodoPago(int idMetodo, string tipo, double monto, string detalles)
        {
            MetodoPagoID = idMetodo;
            Tipo = tipo;
            Monto = monto;
            Detalles = detalles;
            

        }
    }
}
