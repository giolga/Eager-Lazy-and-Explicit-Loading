﻿// <auto-generated />
using EFCoreLoading;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreLoading.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreLoading.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Royal Villa",
                            Price = 200.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Premium Pool Villa",
                            Price = 300.0
                        },
                        new
                        {
                            Id = 3,
                            Name = "luxury Villa",
                            Price = 400.0
                        });
                });

            modelBuilder.Entity("EFCoreLoading.Models.VillaAmenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaAmenities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Private Pool",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Microwave",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Private Balcony",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "1 king bed and 1 sofa bed",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Private Plunge Pool",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Microwave and mini refrigerator",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Private Pool",
                            VillaId = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "Jacuzzi",
                            VillaId = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Private Balcony",
                            VillaId = 1
                        });
                });

            modelBuilder.Entity("EFCoreLoading.Models.VillaAmenity", b =>
                {
                    b.HasOne("EFCoreLoading.Models.Villa", "Villa")
                        .WithMany("VillaAmenity")
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("EFCoreLoading.Models.Villa", b =>
                {
                    b.Navigation("VillaAmenity");
                });
#pragma warning restore 612, 618
        }
    }
}
