using Microsoft.EntityFrameworkCore;
using SarayCilingir.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarayCilingir.Repository.Concrete.EntityFramework
{
    public class SarayContext:DbContext
    {
        public SarayContext(DbContextOptions<SarayContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ProductAttribute> Attributes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(pk => new { pk.ProductId, pk.CategoryId });
        }


    }
}
