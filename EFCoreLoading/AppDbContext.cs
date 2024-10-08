using EFCoreLoading.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLoading
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaAmenity> VillaAmenities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                    new Villa
                    {
                        Id = 1,
                        Name = "Royal Villa",
                        Price = 200
                    },
                    new Villa
                    {
                        Id = 2,
                        Name = "Premium Pool Villa",
                        Price = 300
                    },
                    new Villa
                    {
                        Id = 3,
                        Name = "luxury Villa",
                        Price = 400
                    }
                );

            modelBuilder.Entity<VillaAmenity>().HasData(
                    new VillaAmenity
                    {
                        Id = 1,
                        VillaId = 1,
                        Name = "Private Pool"
                    },
                    new VillaAmenity
                    {
                        Id = 2,
                        VillaId = 1,
                        Name = "Microwave"
                    },
                    new VillaAmenity
                    {
                        Id = 3,
                        VillaId = 1,
                        Name = "Private Balcony"
                    },
                    new VillaAmenity
                    {
                        Id = 4,
                        VillaId = 1,
                        Name = "1 king bed and 1 sofa bed"
                    },

                    new VillaAmenity
                    {
                        Id = 5,
                        VillaId = 2,
                        Name = "Private Plunge Pool"
                    },
                    new VillaAmenity
                    {
                        Id = 6,
                        VillaId = 2,
                        Name = "Microwave and mini refrigerator"
                    },

                    new VillaAmenity
                    {
                        Id = 7,
                        VillaId = 3,
                        Name = "Private Pool"
                    },
                    new VillaAmenity
                    {
                        Id = 8,
                        VillaId = 3,
                        Name = "Jacuzzi"
                    },
                    new VillaAmenity
                    {
                        Id = 9,
                        VillaId = 1,
                        Name = "Private Balcony"
                    }
                );

        }

    }
}
