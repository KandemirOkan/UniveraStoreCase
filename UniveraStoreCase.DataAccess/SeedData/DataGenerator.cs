using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UniveraStoreCase.DataAccess.Data;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.SeedData
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UniveraDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<UniveraDbContext>>()))
            {
                // Look for any book.
                if (context.Product.Any())
                {
                    return;   // Data was already seeded
                }

                context.Product.AddRange(
                new Product { Name = "Satılık Skoda Fabia", Price = 175000, Description = "Sahibinden Temiz Skoda Fabia, Kazasız. 2004 model tdi 75hp.", ModelYear = 2004 },
                new Product { Name = "Satılık Fiat Punto", Price = 250000, Description = "2006 Model az kullanılmış Fiat Punto", ModelYear = 2006 },
                new Product { Name = "Satılık Mercedes E200", Price = 700000, Description = "2000 Model hasarsız Merceses", ModelYear = 2000 },
                new Product { Name = "Satılık Audi A8", Price = 750000, Description = "2015 Model satılık Audi A8", ModelYear = 2015 },
                new Product { Name = "Satılık Audi A6", Price = 650000, Description = "2013 Model satılık Audi A6", ModelYear = 2013 },
                new Product { Name = "Satılık Renault Clio", Price = 350000, Description = "Uygun fiyatlı Renault Clio", ModelYear = 2016 },
                new Product { Name = "Satılık Ford Transit", Price = 450000, Description = "Ford Transit hasarsız, ay yakıt harcar.", ModelYear = 2020 },
                new Product { Name = "Satılık Renault Kangoo", Price = 150000, Description = "2008 Model Reanult Kangoo satılıktır.", ModelYear = 2008 },
                new Product { Name = "Satılık Ford Fiesta", Price = 200000, Description = "Doktordan temiz Ford Fiesta satılık", ModelYear = 2018 },
                new Product { Name = "Satılık Man TGA", Price = 1750000, Description = "Satılık Man marka Kamyon 2016 model.", ModelYear = 2016 },
                new Product { Name = "Satılık Ferrari 812 GTS.", Price = 17500000, Description = "Satılık Ferrari 812 GTS. Spor model.", ModelYear = 2022 },
                new Product { Name = "Satılık Volkswagen Golf", Price = 600000, Description = "2011 model VolksWagen Golf satılık. ", ModelYear = 2011 },
                new Product { Name = "Satılık Volkswagen Passat", Price = 800000, Description = "Wolskwagen passat hasar kayıtsız.", ModelYear = 2016 },
                new Product { Name = "Satılık Volkswagen Polo", Price = 380000, Description = "110 beygir Volkswage Polo satılık araç.", ModelYear = 2011 },
                new Product { Name = "Satılık Skoda Superb", Price = 550000, Description = "Üst sınıf Skoda Superb 2018 model satılık araç.", ModelYear = 2018 }
                );
                context.SaveChanges();

                context.Category.AddRange(
                    new Category { Color = "Beyaz" },//1
                    new Category { Color = "Siyah" },//2
                    new Category { Color = "Gri" },//3
                    new Category { Color = "Mavi" },//4
                    new Category { Color = "Sarı" },//5
                    new Category { FuelType = "Benzin" },//6
                    new Category { FuelType = "Dizel" },//7
                    new Category { FuelType = "LPG" },//8
                    new Category { FuelType = "Hibrit" },//9
                    new Category { FuelType = "Elektrik" },//10
                    new Category { Brand = "Volkswagen" },//11
                    new Category { Brand = "Fiat" },//12
                    new Category { Brand = "Renault" },//13
                    new Category { Brand = "Ford" },//14
                    new Category { Brand = "Ferrari" },//15
                    new Category { Brand = "Skoda" },//16
                    new Category { Brand = "Man" },//17
                    new Category { Brand = "Audi" },//18
                    new Category { Brand = "Mercedes" },//19
                    new Category { VehicleType = "Hususi" },//20
                    new Category { VehicleType = "Ticari" },//21
                    new Category { VehicleType = "Kamyonet" },//22
                    new Category { VehicleType = "Spor" }//23
                );
                context.SaveChanges();

                context.ProductCategory.AddRange(
                    new ProductCategory { ProductId = 1, CategoryId = 1 },
                    new ProductCategory { ProductId = 1, CategoryId = 6 },
                    new ProductCategory { ProductId = 1, CategoryId = 16 },
                    new ProductCategory { ProductId = 1, CategoryId = 20 },
                    new ProductCategory { ProductId = 2, CategoryId = 1 },
                    new ProductCategory { ProductId = 2, CategoryId = 6 },
                    new ProductCategory { ProductId = 2, CategoryId = 12 },
                    new ProductCategory { ProductId = 2, CategoryId = 20 },
                    new ProductCategory { ProductId = 3, CategoryId = 1 },
                    new ProductCategory { ProductId = 3, CategoryId = 7 },
                    new ProductCategory { ProductId = 3, CategoryId = 12 },
                    new ProductCategory { ProductId = 3, CategoryId = 20 },
                    new ProductCategory { ProductId = 4, CategoryId = 2 },
                    new ProductCategory { ProductId = 4, CategoryId = 6 },
                    new ProductCategory { ProductId = 4, CategoryId = 18 },
                    new ProductCategory { ProductId = 4, CategoryId = 20 },
                    new ProductCategory { ProductId = 5, CategoryId = 2 },
                    new ProductCategory { ProductId = 5, CategoryId = 6 },
                    new ProductCategory { ProductId = 5, CategoryId = 18 },
                    new ProductCategory { ProductId = 5, CategoryId = 20 },
                    new ProductCategory { ProductId = 6, CategoryId = 3 },
                    new ProductCategory { ProductId = 6, CategoryId = 9 },
                    new ProductCategory { ProductId = 6, CategoryId = 13 },
                    new ProductCategory { ProductId = 6, CategoryId = 20 },
                    new ProductCategory { ProductId = 7, CategoryId = 3 },
                    new ProductCategory { ProductId = 7, CategoryId = 7 },
                    new ProductCategory { ProductId = 7, CategoryId = 14 },
                    new ProductCategory { ProductId = 7, CategoryId = 21 },
                    new ProductCategory { ProductId = 8, CategoryId = 4 },
                    new ProductCategory { ProductId = 8, CategoryId = 8 },
                    new ProductCategory { ProductId = 8, CategoryId = 13 },
                    new ProductCategory { ProductId = 8, CategoryId = 21 },
                    new ProductCategory { ProductId = 9, CategoryId = 4 },
                    new ProductCategory { ProductId = 9, CategoryId = 8 },
                    new ProductCategory { ProductId = 9, CategoryId = 14 },
                    new ProductCategory { ProductId = 9, CategoryId = 20 },
                    new ProductCategory { ProductId = 10, CategoryId = 4 },
                    new ProductCategory { ProductId = 10, CategoryId = 6 },
                    new ProductCategory { ProductId = 10, CategoryId = 17 },
                    new ProductCategory { ProductId = 10, CategoryId = 22 },
                    new ProductCategory { ProductId = 11, CategoryId = 5 },
                    new ProductCategory { ProductId = 11, CategoryId = 6 },
                    new ProductCategory { ProductId = 11, CategoryId = 15 },
                    new ProductCategory { ProductId = 11, CategoryId = 23 },
                    new ProductCategory { ProductId = 12, CategoryId = 5 },
                    new ProductCategory { ProductId = 12, CategoryId = 10 },
                    new ProductCategory { ProductId = 12, CategoryId = 11 },
                    new ProductCategory { ProductId = 12, CategoryId = 20 },
                    new ProductCategory { ProductId = 13, CategoryId = 5 },
                    new ProductCategory { ProductId = 13, CategoryId = 10 },
                    new ProductCategory { ProductId = 13, CategoryId = 11 },
                    new ProductCategory { ProductId = 13, CategoryId = 20 },
                    new ProductCategory { ProductId = 14, CategoryId = 1 },
                    new ProductCategory { ProductId = 14, CategoryId = 6 },
                    new ProductCategory { ProductId = 14, CategoryId = 11 },
                    new ProductCategory { ProductId = 14, CategoryId = 20 },
                    new ProductCategory { ProductId = 15, CategoryId = 1 },
                    new ProductCategory { ProductId = 15, CategoryId = 6 },
                    new ProductCategory { ProductId = 15, CategoryId = 16 },
                    new ProductCategory { ProductId = 15, CategoryId = 20 }
                );
                context.SaveChanges();
            }
        }
    }
}
