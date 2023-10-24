using Microsoft.EntityFrameworkCore;
using webapi.Models;
using Microsoft.Extensions.Configuration;
namespace webapi.Context

{
    public class DBContextP:DbContext 
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=Rosmery_Ventura\\ROSMERY;Database=ProyectoDesarrollo;User Id=Usuario;Password=usuario;");

        //}
       public readonly IConfiguration _configuration;

        public string cadena()
        {
            var str = _configuration.GetConnectionString("SQLCONN");
            return str;
        }

        public DBContextP(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("SQLCONN");
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<EntregaPaquete> entregaPaquetes { get; set; }
        public DbSet<NotasCredito> notasCreditos { get; set; }
        public DbSet<Ventum> ventas { get; set; }
    }
}
