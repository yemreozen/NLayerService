using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductProp : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
             new ProductFeature { Id = 1, Color = "Gri", Height = 120, Width = 15, ProductId = 1 },
             new ProductFeature { Id = 2, Color = "Beyaz", Height = 120, Width = 15, ProductId = 2 },
             new ProductFeature { Id = 3, Color = "Kırmız", Height = 120, Width = 15, ProductId = 1 });
        }
    }
}



