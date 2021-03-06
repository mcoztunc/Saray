﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarayCilingir.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }



        public string Description { get; set; }
        public string HtmlContent { get; set; }
        public DateTime DateAdded { get; set; }


        public string Image { get; set; }

        public bool isApproved { get; set; }

        public bool isHome { get; set; }
        public bool isFeatured { get; set; }
         
        public List<ProductCategory> ProductCategories { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductAttribute> Attributes { get; set; }

    }
}
