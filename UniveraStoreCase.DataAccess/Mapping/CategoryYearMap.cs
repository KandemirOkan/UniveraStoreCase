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
    public class CategoryYearMap : IEntityTypeConfiguration<CategoryYear>
    {
        public void Configure(EntityTypeBuilder<CategoryYear> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Year).HasMaxLength(4);
        }
    }
}
