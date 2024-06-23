using BaseMilitar.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMilitar.context
{
    class DataBaseContext : DbContext
    {
        public DbSet<Mecanico> Mecanico { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Soldado> Soldado { get; set; }
        public DbSet<SoldadoVehiculo> SoldadoVehiculo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                try
                {
                    optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=BaseMilitar;Trusted_Connection=True;");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al configurar la conexión a la base de datos: " + ex.Message);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mecanico>()
                .ToTable("Mecanicos")
                .HasMany(m => m.Vehiculos)
                .WithOne(v => v.mecanico)
                .HasForeignKey(v => v.mecanicoId)
                .IsRequired(false);
            modelBuilder.Entity<Vehiculo>().ToTable("Vehiculos");
            modelBuilder.Entity<Soldado>().ToTable("Soldados");

            modelBuilder.Entity<SoldadoVehiculo>()
                .ToTable("Soldado_Vehiculo");

            modelBuilder.Entity<SoldadoVehiculo>()
            .HasKey(sm => new { sm.soldadoId, sm.VehiculoId });

            modelBuilder.Entity<SoldadoVehiculo>()
                .HasOne(sm => sm.Soldado)
                .WithMany(s => s.SoldadoVehiculo)
                .HasForeignKey(sm => sm.soldadoId);

            modelBuilder.Entity<SoldadoVehiculo>()
                .HasOne(sm => sm.Vehiculo)
                .WithMany(m => m.SoldadoVehiculo)
                .HasForeignKey(sm => sm.VehiculoId);
        }
    }
}
