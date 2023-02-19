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
    public class CategoryFuelTypeMap : IEntityTypeConfiguration<CategoryFuelType>
    {
        public void Configure(EntityTypeBuilder<CategoryFuelType> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.FuelType).HasMaxLength(50);
        }
    }
}
