using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Tarea9Docker.Data
{
    public class ApplicationDbContext : DbContext
    {
    private readonly IConfiguration _configuration;
    public ApplicationDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(_configuration.GetConnectionString("contenedor"));
    }
    public class Empleado
    {
        [Key]
        public int idEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string Apellido { get; set; }

        public string Direccion { get; set; }
        public string? Telefono { get; set; }

        public int idPuesto { get; set; }
        public Puesto Puesto { get; set; }
    }

    public class Puesto
    {
        [Key]
        public int idPuesto { get; set; }
        public string nombrePuesto { get; set; }
    }

}
