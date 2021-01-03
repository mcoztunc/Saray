using SarayCilingir.Entity;
using SarayCilingir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SarayCilingir.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {
        public EfProductRepository(SarayContext context):base(context)
        {

        }


        public SarayContext SarayContext
        {
            get { return context as SarayContext; }
        }
        public List<Product> GetTop5Products()
        {
            return SarayContext.Products
                           .OrderByDescending(i => i.ProductId)
                            .Take(5)
                            .ToList();
        }
    }
}
