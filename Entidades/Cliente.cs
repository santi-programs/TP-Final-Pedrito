using Entidades;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public bool MinoristaMayorista { get; set; }
        public string Telefono { get; set; }
        public virtual ICollection<Venta> ventas { get; set; } = new List<Venta>();


        public Cliente(int idCliente, string nombre, string apellido,string dni, bool minoristaMayorista, string telefono ) 
        { 
           IDCliente = idCliente;
           Nombre = nombre;
           Apellido = apellido;
           DNI = dni;
           MinoristaMayorista = minoristaMayorista;
           Telefono = telefono;
        }

       
    }
}
