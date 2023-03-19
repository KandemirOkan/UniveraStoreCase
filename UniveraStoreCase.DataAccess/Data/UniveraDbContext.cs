using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.DataAccess.SeedData;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.Data
{
    public class UniveraDbContext:DbContext
    {
        public UniveraDbContext(DbContextOptions<UniveraDbContext> options):base(options) 
        {
        
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<List> List { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
