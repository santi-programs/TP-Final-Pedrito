using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    //Con esta clase se llama a la Base de Datos y se crean las tablas
    public class Context : DbContext
    {
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<ReporteConsulta> Reportes { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<MetodoPago> MetodosDePago { get; set; }

        public string Cadena = "Data Source=(localdb)\\MSSQLLocalDB;" +
                            "Initial Catalog=TechStoreVentasDB;" +
                            "Integrated Security=True;" +
                            "Trust Server Certificate=True;";
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

