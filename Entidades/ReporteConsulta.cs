using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class ReporteConsulta
    {
        public int ReporteConsultaID { get; set; }
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public string Sucursal { get; set; }
        public int VendedorID { get; set; }
        public double Monto { get; set; }

        public ReporteConsulta(){   }
        public ReporteConsulta(DateTime fecha, string producto, string sucursal, int idVendedor, double monto)
        {
            
            Fecha = fecha;
            Producto = producto;
            Sucursal = sucursal;
            VendedorID = idVendedor;
            Monto = monto;
        }
    }
}
