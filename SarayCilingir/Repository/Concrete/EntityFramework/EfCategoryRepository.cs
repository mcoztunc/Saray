using SarayCilingir.Entity;
using SarayCilingir.Models;
using SarayCilingir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SarayCilingir.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(SarayContext context):base(context)
        {

        }

        public SarayContext SarayContext
        {
            get { return context as SarayContext; }
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel() {
            CategoryId=i.CategoryId,CategoryName=i.CategoryName,Count=i.ProductCategoriess.Count()
            
            });
        }

        public Category GetByName(string name)
        {
            return SarayContext.Categories.Where(i => i.CategoryName == name).FirstOrDefault();    
        }


    }
}
