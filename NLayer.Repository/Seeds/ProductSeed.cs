using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() {Id=1,CategoryId=1,ProductName="Kalem1",Price=200,Stock=20,CreatedDate=DateTime.Now},
                new Product() {Id=2,CategoryId=1,ProductName="Kalem2",Price=250,Stock=10,CreatedDate=DateTime.Now},
                new Product() {Id=3,CategoryId=1,ProductName="Kalem3",Price=300,Stock=50,CreatedDate=DateTime.Now},
                new Product() {Id=4,CategoryId=2,ProductName="Kitap1",Price=550,Stock=5,CreatedDate=DateTime.Now}
                );
        }
    }
}
