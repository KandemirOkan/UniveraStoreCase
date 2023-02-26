using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.Entities.Entities;

namespace UniveraStoreCase.DataAccess.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => c.Price).HasPrecision(16,2);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.Name).HasMaxLength(100);
        }
    }
}
