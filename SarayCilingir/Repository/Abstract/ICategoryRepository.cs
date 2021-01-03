using SarayCilingir.Entity;
using SarayCilingir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SarayCilingir.Repository.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Category GetByName(string name);
        IEnumerable<CategoryModel> GetAllWithProductCount();
    }
}
