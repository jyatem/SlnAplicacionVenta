using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionVenta.DataAccess
{
    public class VentaDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("DBVentaTecnologia");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria(1, "Electronicos"),
                new Categoria(2, "Computadoras"),
                new Categoria(3, "Teléfonos Móviles"),
                new Categoria(4, "Dispositivos de escritorio"),
                new Categoria(5, "Microfonos y audio"),
                new Categoria(6, "Artefactos del hogar"),
                new Categoria(7, "Juegos")
                );

            modelBuilder.Entity<Producto>().HasData(
                new Producto(1, "Radio digital", "En un radio de ancha banda", 100, 1),
                new Producto(2, "Laptop HP", "Portatil para escritorio y manejo de office", 900, 2),
                new Producto(3, "Laptop Acer", "Portatil para juegos", 1200, 2),
                new Producto(4, "Samsung S25+", "Teléfono con 5G y media", 1300, 3),
                new Producto(5, "Age Empires", "Juego de guerra", 500, 7)
                );

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente(1, "Jairo Yate", "Calle 100"),
                new Cliente(2, "Lina Mora", "Carrera 200")
                );
        }
    }

    // Categorias de unos productos
    public record Categoria(int Id, string Nombre);

    // Productos
    public record Producto(int Id, string Nombre, string Descripcion, decimal Precio, int CategoriaId)
    {
        public Categoria Categoria { get; set; }
    }

    // Clientes
    public record Cliente(int Id, string Nombre, string Direccion);
}
