using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SarayCilingir.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarayCilingir.Repository.Concrete.EntityFramework
{
    public static class VeriEkle
    {
        public static void Veriler(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<SarayContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="kale 68mm barel",Price=70,Image="product1.jpg",isHome=true,isApproved=true,isFeatured=true,Description="68mm kilit lorem ipsum",DateAdded=DateTime.Now.AddDays(-10)},
                    new Product(){ProductName="kale 90mm barel",Price=100,Image="product2.jpg",isHome=true,isApproved=true,isFeatured=true,Description="90mm kilit lorem ipsum dolor si amet",DateAdded=DateTime.Now.AddDays(-20)}

                };

                context.Products.AddRange(products);

                var images = new[]
               {
                    new Image(){ ImageName="product1.jpg", Product=products[0]},
                    new Image(){ ImageName="product2.jpg", Product=products[0]},
                    new Image(){ ImageName="product3.jpg", Product=products[0]},
                    new Image(){ ImageName="product4.jpg", Product=products[0]},

                    new Image(){ ImageName="product1.jpg", Product=products[1]},
                    new Image(){ ImageName="product2.jpg", Product=products[1]},
                    new Image(){ ImageName="product3.jpg", Product=products[1]},
                    new Image(){ ImageName="product4.jpg", Product=products[1]},
                };

                context.Images.AddRange(images);


                var attributes = new[]
               {
                    new ProductAttribute(){ Attribute="Display",Value="15.6", Product=products[0]},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7", Product=products[0]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB", Product=products[0]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB", Product=products[0]},
                    new ProductAttribute(){ Attribute="Color",Value="Black", Product=products[0]},

                    new ProductAttribute(){ Attribute="Display",Value="15.6", Product=products[1]},
                    new ProductAttribute(){ Attribute="Processor",Value="Intel i7", Product=products[1]},
                    new ProductAttribute(){ Attribute="RAM Memory",Value="8 GB", Product=products[1]},
                    new ProductAttribute(){ Attribute="Hard Disk",Value="1 TB", Product=products[1]},
                    new ProductAttribute(){ Attribute="Color",Value="Black", Product=products[1]},
                };

                context.Attributes.AddRange(attributes);





                var categories = new[]
                {
                    new Category(){CategoryName="Barel"}

                };

                context.Categories.AddRange(categories);

                var productcategories = new[]
                {
                    new ProductCategory()
                    {Product=products[0],Category=categories[0] }


                };
                context.AddRange(productcategories);
                context.SaveChanges();
            }
        }

    }
}
