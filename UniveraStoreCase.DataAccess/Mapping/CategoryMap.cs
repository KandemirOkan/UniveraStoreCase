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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Brand).HasMaxLength(50);
            builder.Property(c => c.FuelType).HasMaxLength(50);
            builder.Property(c => c.Color).HasMaxLength(50);
        }
    }
}
