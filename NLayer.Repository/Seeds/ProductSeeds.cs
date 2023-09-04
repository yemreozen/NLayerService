using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeeds : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
           new Product { Id = 1, CategoryId = 1, Price = 100, Stock = 20, CreationDate = DateTime.Now, Name = "Kalem1" },
           new Product { Id = 2, CategoryId = 2, Price = 200, Stock = 30, CreationDate = DateTime.Now, Name = "Kitap1" },
           new Product { Id = 3, CategoryId = 3, Price = 300, Stock = 40, CreationDate = DateTime.Now, Name = "Defter1" });
        }
    }
}
