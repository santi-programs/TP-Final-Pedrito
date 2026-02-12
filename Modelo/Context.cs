using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Modelo
{
    //Con esta clase se llama a la Base de Datos y se crean las tablas
    public class Context : DbContext
    {
        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<ReporteConsulta> ReporteConsulta { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<MetodoPago> MetodosPago { get; set; }

        //public const string Cadena = @"Data Source=ARSL\SQLEXPRESS;Initial Catalog=TechStoreVentasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public const string Cadena = @"Data Source=hp;Initial Catalog=FinalPedrito;Integrated Security=True;Encrypt=False";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Cadena,

                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();
                }
            );
        }
    }
}

