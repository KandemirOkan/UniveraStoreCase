﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniveraStoreCase.DataAccess.Data;

#nullable disable

namespace UniveraStoreCase.DataAccess.Migrations
{
    [DbContext(typeof(UniveraDbContext))]
    [Migration("20230220205141_dataseed")]
    partial class dataseed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CategoryBrands");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CategoryColors");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryFuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FuelType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CategoryFuelTypes");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryVehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("VehicleType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CategoryVehicleTypes");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Year")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CategoryYears");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryBrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryColorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryFuelTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryVehicleTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryYearId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(16, 2)
                        .HasColumnType("decimal(16,2)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryBrandId");

                    b.HasIndex("CategoryColorId");

                    b.HasIndex("CategoryFuelTypeId");

                    b.HasIndex("CategoryVehicleTypeId");

                    b.HasIndex("CategoryYearId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryBrandId = 6,
                            CategoryColorId = 1,
                            CategoryFuelTypeId = 1,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 15,
                            Description = "Sahibinden Temiz Skoda Fabia, Kazasız. 2004 model tdi 75hp.",
                            Name = "Satılık Skoda Fabia",
                            Price = 175000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryBrandId = 2,
                            CategoryColorId = 1,
                            CategoryFuelTypeId = 1,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 17,
                            Description = "2006 Model az kullanılmış Fiat Punto",
                            Name = "Satılık Fiat Punto",
                            Price = 250000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryBrandId = 1,
                            CategoryColorId = 1,
                            CategoryFuelTypeId = 2,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 11,
                            Description = "2000 Model hasarsız Merceses",
                            Name = "Satılık Mercedes E200",
                            Price = 700000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryBrandId = 8,
                            CategoryColorId = 2,
                            CategoryFuelTypeId = 1,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 26,
                            Description = "2015 Model satılık Audi A8",
                            Name = "Satılık Audi A8",
                            Price = 750000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryBrandId = 8,
                            CategoryColorId = 2,
                            CategoryFuelTypeId = 1,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 24,
                            Description = "2013 Model satılık Audi A6",
                            Name = "Satılık Audi A6",
                            Price = 650000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 6,
                            CategoryBrandId = 3,
                            CategoryColorId = 3,
                            CategoryFuelTypeId = 4,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 1,
                            Description = "Uygun fiyatlı Renault Clio",
                            Name = "Satılık Renault Clio",
                            Price = 350000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 7,
                            CategoryBrandId = 4,
                            CategoryColorId = 3,
                            CategoryFuelTypeId = 2,
                            CategoryVehicleTypeId = 2,
                            CategoryYearId = 1,
                            Description = "Ford Transit hasarsız, ay yakıt harcar.",
                            Name = "Satılık Ford Transit",
                            Price = 450000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 8,
                            CategoryBrandId = 3,
                            CategoryColorId = 4,
                            CategoryFuelTypeId = 3,
                            CategoryVehicleTypeId = 2,
                            CategoryYearId = 19,
                            Description = "2008 Model Reanult Kangoo satılıktır.",
                            Name = "Satılık Renault Kangoo",
                            Price = 150000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 9,
                            CategoryBrandId = 4,
                            CategoryColorId = 4,
                            CategoryFuelTypeId = 3,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 1,
                            Description = "Doktordan temiz Ford Fiesta satılık",
                            Name = "Satılık Ford Fiesta",
                            Price = 200000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 10,
                            CategoryBrandId = 7,
                            CategoryColorId = 4,
                            CategoryFuelTypeId = 1,
                            CategoryVehicleTypeId = 3,
                            CategoryYearId = 27,
                            Description = "Satılık Man marka Kamyon 2016 model.",
                            Name = "Satılık Man TGA",
                            Price = 1750000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 11,
                            CategoryBrandId = 5,
                            CategoryColorId = 5,
                            CategoryFuelTypeId = 1,
                            CategoryVehicleTypeId = 4,
                            CategoryYearId = 1,
                            Description = "Satılık Ferrari 812 GTS. Spor model.",
                            Name = "Satılık Ferrari 812 GTS.",
                            Price = 17500000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 12,
                            CategoryBrandId = 1,
                            CategoryColorId = 5,
                            CategoryFuelTypeId = 5,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 22,
                            Description = "2011 model VolksWagen Golf satılık. ",
                            Name = "Satılık Volkswagen Golf",
                            Price = 600000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 13,
                            CategoryBrandId = 1,
                            CategoryColorId = 5,
                            CategoryFuelTypeId = 5,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 1,
                            Description = "Wolskwagen passat hasar kayıtsız.",
                            Name = "Satılık Volkswagen Passat",
                            Price = 800000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 14,
                            CategoryBrandId = 1,
                            CategoryColorId = 1,
                            CategoryFuelTypeId = 1,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 1,
                            Description = "110 beygir Volkswage Polo satılık araç.",
                            Name = "Satılık Volkswagen Polo",
                            Price = 380000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 15,
                            CategoryBrandId = 6,
                            CategoryColorId = 1,
                            CategoryFuelTypeId = 1,
                            CategoryVehicleTypeId = 1,
                            CategoryYearId = 29,
                            Description = "Üst sınıf Skoda Superb 2018 model satılık araç.",
                            Name = "Satılık Skoda Superb",
                            Price = 550000m,
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        });
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.Product", b =>
                {
                    b.HasOne("UniveraStoreCase.Entities.Entities.CategoryBrand", "CategoryBrand")
                        .WithMany("Product")
                        .HasForeignKey("CategoryBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniveraStoreCase.Entities.Entities.CategoryColor", "CategoryColor")
                        .WithMany("Product")
                        .HasForeignKey("CategoryColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniveraStoreCase.Entities.Entities.CategoryFuelType", "CategoryFuelType")
                        .WithMany("Product")
                        .HasForeignKey("CategoryFuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniveraStoreCase.Entities.Entities.CategoryVehicleType", "CategoryVehicleType")
                        .WithMany("Product")
                        .HasForeignKey("CategoryVehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniveraStoreCase.Entities.Entities.CategoryYear", "CategoryYear")
                        .WithMany("Product")
                        .HasForeignKey("CategoryYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryBrand");

                    b.Navigation("CategoryColor");

                    b.Navigation("CategoryFuelType");

                    b.Navigation("CategoryVehicleType");

                    b.Navigation("CategoryYear");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryBrand", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryColor", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryFuelType", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryVehicleType", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("UniveraStoreCase.Entities.Entities.CategoryYear", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}