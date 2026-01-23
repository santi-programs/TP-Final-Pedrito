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
        private DateTime Fecha { get; set; }
        private string Producto { get; set; }
        private string Sucursal { get; set; }
        private int IDVendedor { get; set; }
        private int IDSucursal { get; set; }
        public ReporteConsulta(DateTime fecha, string producto, string sucursal, int idVendedor, int idSucursal)
        {
            Fecha = fecha;
            Producto = producto;
            Sucursal = sucursal;
            IDVendedor = idVendedor;
            IDSucursal = idSucursal;
        }
    }
}
