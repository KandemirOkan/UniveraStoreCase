using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.DataAccess.Data;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.SeedData
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Name = "Satılık Skoda Fabia", Price = 175000, Description = "Sahibinden Temiz Skoda Fabia, Kazasız. 2004 model tdi 75hp.", Id = 1, CategoryBrandId = 6, CategoryColorId = 1, CategoryFuelTypeId = 1, CategoryYearId = 15, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Fiat Punto", Price = 250000, Description = "2006 Model az kullanılmış Fiat Punto", Id = 2, CategoryBrandId = 2, CategoryColorId = 1, CategoryFuelTypeId = 1, CategoryYearId = 17, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Mercedes E200", Price = 700000, Description = "2000 Model hasarsız Merceses", Id = 3, CategoryBrandId = 1, CategoryColorId = 1, CategoryFuelTypeId = 2, CategoryYearId = 11, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Audi A8", Price = 750000, Description = "2015 Model satılık Audi A8", Id = 4, CategoryBrandId = 8, CategoryColorId = 2, CategoryFuelTypeId = 1, CategoryYearId = 26, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Audi A6", Price = 650000, Description = "2013 Model satılık Audi A6", Id = 5, CategoryBrandId = 8, CategoryColorId = 2, CategoryFuelTypeId = 1, CategoryYearId = 24, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Renault Clio", Price = 350000, Description = "Uygun fiyatlı Renault Clio", Id = 6, CategoryBrandId = 3, CategoryColorId = 3, CategoryFuelTypeId = 4, CategoryYearId = 1, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Ford Transit", Price = 450000, Description = "Ford Transit hasarsız, ay yakıt harcar.", Id = 7, CategoryBrandId = 4, CategoryColorId = 3, CategoryFuelTypeId = 2, CategoryYearId = 1, CategoryVehicleTypeId = 2 },
                new Product { Name = "Satılık Renault Kangoo", Price = 150000, Description = "2008 Model Reanult Kangoo satılıktır.", Id = 8, CategoryBrandId = 3, CategoryColorId = 4, CategoryFuelTypeId = 3, CategoryYearId = 19, CategoryVehicleTypeId = 2 },
                new Product { Name = "Satılık Ford Fiesta", Price = 200000, Description = "Doktordan temiz Ford Fiesta satılık", Id = 9, CategoryBrandId = 4, CategoryColorId = 4, CategoryFuelTypeId = 3, CategoryYearId = 1, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Man TGA", Price = 1750000, Description = "Satılık Man marka Kamyon 2016 model.", Id = 10, CategoryBrandId = 7, CategoryColorId = 4, CategoryFuelTypeId = 1, CategoryYearId = 27, CategoryVehicleTypeId = 3 },
                new Product { Name = "Satılık Ferrari 812 GTS.", Price = 17500000, Description = "Satılık Ferrari 812 GTS. Spor model.", Id = 11, CategoryBrandId = 5, CategoryColorId = 5, CategoryFuelTypeId = 1, CategoryYearId = 1, CategoryVehicleTypeId = 4 },
                new Product { Name = "Satılık Volkswagen Golf", Price = 600000, Description = "2011 model VolksWagen Golf satılık. ", Id = 12, CategoryBrandId = 1, CategoryColorId = 5, CategoryFuelTypeId = 5, CategoryYearId = 22, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Volkswagen Passat", Price = 800000, Description = "Wolskwagen passat hasar kayıtsız.", Id = 13, CategoryBrandId = 1, CategoryColorId = 5, CategoryFuelTypeId = 5, CategoryYearId = 1, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Volkswagen Polo", Price = 380000, Description = "110 beygir Volkswage Polo satılık araç.", Id = 14, CategoryBrandId = 1, CategoryColorId = 1, CategoryFuelTypeId = 1, CategoryYearId = 1, CategoryVehicleTypeId = 1 },
                new Product { Name = "Satılık Skoda Superb", Price = 550000, Description = "Üst sınıf Skoda Superb 2018 model satılık araç.", Id = 15, CategoryBrandId = 6, CategoryColorId = 1, CategoryFuelTypeId = 1, CategoryYearId = 29, CategoryVehicleTypeId = 1 }
                );

                modelBuilder.Entity<CategoryColor>().HasData(
                new CategoryColor { Color = "Beyaz", Id = 1 },
                new CategoryColor { Color = "Siyah", Id = 2 },
                new CategoryColor { Color = "Gri", Id = 3 },
                new CategoryColor { Color = "Mavi", Id = 4 },
                new CategoryColor { Color = "Sarı", Id = 5 }
                );

                modelBuilder.Entity<CategoryFuelType>().HasData(
                new CategoryFuelType { FuelType = "Benzin", Id = 1 },
                new CategoryFuelType { FuelType = "Dizel", Id = 2 },
                new CategoryFuelType { FuelType = "LPG", Id = 3 },
                new CategoryFuelType { FuelType = "Hibrit", Id = 4 },
                new CategoryFuelType { FuelType = "Elektrik", Id = 5 }
                );
                modelBuilder.Entity<CategoryBrand>().HasData(
                new CategoryBrand { Brand = "Volkswagen", Id = 1 },
                new CategoryBrand { Brand = "Fiat", Id = 2 },
                new CategoryBrand { Brand = "Renault", Id = 3 },
                new CategoryBrand { Brand = "Ford", Id = 4 },
                new CategoryBrand { Brand = "Ferrari", Id = 5 },
                new CategoryBrand { Brand = "Skoda", Id = 6 },
                new CategoryBrand { Brand = "Man", Id = 7 },
                new CategoryBrand { Brand = "Audi", Id = 8 }
                );
                modelBuilder.Entity<CategoryVehicleType>().HasData(
                new CategoryVehicleType { VehicleType = "Hususi", Id = 1 },
                new CategoryVehicleType { VehicleType = "Ticari", Id = 2 },
                new CategoryVehicleType { VehicleType = "Kamyonet", Id = 3 },
                new CategoryVehicleType { VehicleType = "Spor", Id = 4 }
                );
                modelBuilder.Entity<CategoryYear>().HasData(
                new CategoryYear { Year = 1990, Id = 1 },
                new CategoryYear { Year = 1991, Id = 2 },
                new CategoryYear { Year = 1992, Id = 3 },
                new CategoryYear { Year = 1993, Id = 4 },
                new CategoryYear { Year = 1994, Id = 5 },
                new CategoryYear { Year = 1995, Id = 6 },
                new CategoryYear { Year = 1996, Id = 7 },
                new CategoryYear { Year = 1997, Id = 8 },
                new CategoryYear { Year = 1998, Id = 9 },
                new CategoryYear { Year = 1999, Id = 10 },
                new CategoryYear { Year = 2000, Id = 11 },
                new CategoryYear { Year = 2001, Id = 12 },
                new CategoryYear { Year = 2002, Id = 13 },
                new CategoryYear { Year = 2003, Id = 14 },
                new CategoryYear { Year = 2004, Id = 15 },
                new CategoryYear { Year = 2005, Id = 16 },
                new CategoryYear { Year = 2006, Id = 17 },
                new CategoryYear { Year = 2007, Id = 18 },
                new CategoryYear { Year = 2008, Id = 19 },
                new CategoryYear { Year = 2009, Id = 20 },
                new CategoryYear { Year = 2010, Id = 21 },
                new CategoryYear { Year = 2011, Id = 22 },
                new CategoryYear { Year = 2012, Id = 23 },
                new CategoryYear { Year = 2013, Id = 24 },
                new CategoryYear { Year = 2014, Id = 25 },
                new CategoryYear { Year = 2015, Id = 26 },
                new CategoryYear { Year = 2016, Id = 27 },
                new CategoryYear { Year = 2017, Id = 28 },
                new CategoryYear { Year = 2018, Id = 29 },
                new CategoryYear { Year = 2019, Id = 30 },
                new CategoryYear { Year = 2020, Id = 31 },
                new CategoryYear { Year = 2021, Id = 32 },
                new CategoryYear { Year = 2022, Id = 33 },
                new CategoryYear { Year = 2023, Id = 34 }
                );
        }
    }
}
