using Microsoft.EntityFrameworkCore;
using Turnos.Models;

namespace Turnos.Models
{
    public class TurnosContext : DbContext
    {

        public TurnosContext(DbContextOptions<TurnosContext> opciones)
        : base(opciones)
        {
            
        }

        public DbSet<Especialidad> Especialidad { get; set; }
        
        public DbSet<Paciente> Paciente { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidad>(entidad => 
            {
                entidad.ToTable("Especialidad");

                entidad.HasKey(e => e.IdEspecialidad);

                entidad.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            }
            );
        }

    }

      
}