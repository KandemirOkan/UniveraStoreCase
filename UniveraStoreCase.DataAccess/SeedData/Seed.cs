//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UniveraStoreCase.DataAccess.Data;
//using UniveraStoreCase.Entities.Entities;

//namespace UniveraStoreCase.DataAccess.SeedData
//{
//    public static class Seed
//    {
//        public static void SeedData()
//        {
//            UniveraDbContext db = new UniveraDbContext();
//            List<Product> products = new List<Product>();
//            {
//                new Product { Name = "Satılık Skoda Fabia", Price = 175000, Description = "Sahibinden Temiz Skoda Fabia, Kazasız. 2004 model tdi 75hp." };
//            };
//            db.Products.AddRange(products);
//            db.SaveChanges();
//        }

//    }
//}
