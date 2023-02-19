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
    public class CategoryColorMap : IEntityTypeConfiguration<CategoryColor>
    {
        public void Configure(EntityTypeBuilder<CategoryColor> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Color).HasMaxLength(50);
        }
    }
}
