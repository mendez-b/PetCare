using PetCare.Models;
using Microsoft.EntityFrameworkCore;
using PetCare.Api.Models.PetCare.Models;
using PetCare.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using PetCare.Api.Models;

namespace PetCare.Data
{
    public class PetCareDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<CitaProducto> CitaProductos { get; set; }

        public PetCareDbContext(DbContextOptions<PetCareDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación: Cliente 1:N Mascotas
            modelBuilder.Entity<Mascota>()
                .HasOne(m => m.Cliente)
                .WithMany(c => c.Mascotas)
                .HasForeignKey(m => m.IdCliente);

            // Relación: Mascota 1:N Citas
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.Mascota)
                .WithMany(m => m.Citas)
                .HasForeignKey(c => c.IdMascota);

            // Relación: Servicio 1:N Citas
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.Servicio)
                .WithMany(s => s.Citas)
                .HasForeignKey(c => c.IdServicio);

            // Relación muchos a muchos (tabla intermedia con campo adicional)
            modelBuilder.Entity<CitaProducto>()
                .HasKey(cp => new { cp.IdCita, cp.IdProducto });

            modelBuilder.Entity<CitaProducto>()
                .HasOne(cp => cp.Cita)
                .WithMany(c => c.CitaProductos)
                .HasForeignKey(cp => cp.IdCita);

            modelBuilder.Entity<CitaProducto>()
                .HasOne(cp => cp.Producto)
                .WithMany(p => p.CitaProductos) 
                .HasForeignKey(cp => cp.IdProducto);

            // Relación: Proveedor 1:N Productos
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Proveedor)
                .WithMany(pr => pr.Productos)
                .HasForeignKey(p => p.IdProveedor);
        }
    }
}
