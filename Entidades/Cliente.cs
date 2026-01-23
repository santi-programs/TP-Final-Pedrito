using Entidades;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Cliente
    {
        private int IDCliente { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string DNI { get; set; }
        private bool MinoristaMayorista { get; set; }
        private string Telefono { get; set; }
      

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
