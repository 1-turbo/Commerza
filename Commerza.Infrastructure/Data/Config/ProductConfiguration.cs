using Commerza.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;

namespace Commerza.Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.HasData(
                new Product { Id = 1, Name = "test", Description = "test",CategoryID = 1, Price=12 }
                );
        }
    }
}
