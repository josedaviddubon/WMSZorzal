using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ZorzalContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> WareHouses { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=172.20.11.4; Database=WMSZorzal; User Id=sa; password=Vh.2021.$$@$");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryID = "CAT001", CategoryName = "Materiales de Construcción" },
                new CategoryEntity { CategoryID = "CAT002", CategoryName = "Herramientas y Equipos" },
                new CategoryEntity { CategoryID = "CAT003", CategoryName = "Maquinaria Pesada" },
                new CategoryEntity { CategoryID = "CAT004", CategoryName = "Diseño Arquitectónico" },
                new CategoryEntity { CategoryID = "CAT005", CategoryName = "Estructuras Metálicas" },
                new CategoryEntity { CategoryID = "CAT006", CategoryName = "Sistemas Eléctricos" },
                new CategoryEntity { CategoryID = "CAT007", CategoryName = "Climatización y Ventilación" },
                new CategoryEntity { CategoryID = "CAT008", CategoryName = "Construcción Residencial" },
                new CategoryEntity { CategoryID = "CAT009", CategoryName = "Construcción Comercial" },
                new CategoryEntity { CategoryID = "CAT010", CategoryName = "Gestión de Proyectos" }
            );


            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity
                {
                    WarehouseID = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Central",
                    WarehouseAddress = "Calle Uno"
                },
                 new WarehouseEntity
                 {
                     WarehouseID = Guid.NewGuid().ToString(),
                     WarehouseName = "Bodega Norte",
                     WarehouseAddress = "Calle 33"
                 }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    ProductId = "PROD001",ProductName = "Ladrillos Cerámicos",ProductDescription = "Ladrillos de alta resistencia para construcción",TotalQuantity = 100,
                    CategoryID = "CAT001" // Asigna la categoría correspondiente
                },
                new ProductEntity
                {
                    ProductId = "PROD002",ProductName = "Martillo Eléctrico",ProductDescription = "Martillo percutor para trabajos de demolición",TotalQuantity = 20,
                    CategoryID = "CAT002" // Asigna la categoría correspondiente
                },
                new ProductEntity
                {
                    ProductId = "PROD003",ProductName = "Excavadora Caterpillar",ProductDescription = "Excavadora para movimientos de tierra",TotalQuantity = 5,CategoryID = "CAT003" // Asigna la categoría correspondiente
                }
                );
        }

    }
}
