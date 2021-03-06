using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApiP223.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApiP223.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.SalePrice).IsRequired(true).HasColumnType("decimal(18,2)");
            builder.Property(x => x.CostPrice).IsRequired(true).HasColumnType("decimal(18,2)");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            builder.Property(x => x.ModifiedAt).HasDefaultValueSql("GETUTCDATE()");
            builder.HasOne(x => x.Category).WithMany(x => x.Products).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
