using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.Data
{
    public class UniveraDbContext:DbContext
    {
        public UniveraDbContext(DbContextOptions<UniveraDbContext> options):base(options) 
        {
        
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryBrand> CategoryBrands { get; set; }
        public DbSet<CategoryColor> CategoryColors { get; set; }
        public DbSet<CategoryVehicleType> CategoryVehicleTypes { get; set; }
        public DbSet<CategoryYear> CategoryYears { get; set; }
        public DbSet<CategoryFuelType> CategoryFuelTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
