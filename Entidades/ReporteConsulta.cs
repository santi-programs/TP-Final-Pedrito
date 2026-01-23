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
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public string Sucursal { get; set; }
        public int IDVendedor { get; set; }
        public decimal Monto { get; set; }
        public ReporteConsulta(DateTime fecha, string producto, string sucursal, int idVendedor, int idSucursal, decimal monto)
        {
            Fecha = fecha;
            Producto = producto;
            Sucursal = sucursal;
            IDVendedor = idVendedor;
            Monto = monto;
        }
    }
}
