using Microsoft.EntityFrameworkCore;
using ColegioSanJose.Models;

namespace ColegioSanJose.Data
{
    public class ColegioContext : DbContext
    {
        public ColegioContext(DbContextOptions<ColegioContext> options)
            : base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Expediente> Expedientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expediente>()
                .Property(e => e.NotaFinal)
                .HasPrecision(5, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}