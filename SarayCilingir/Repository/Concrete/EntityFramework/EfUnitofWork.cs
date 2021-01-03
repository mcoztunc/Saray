using SarayCilingir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarayCilingir.Repository.Concrete.EntityFramework
{
    public class EfUnitofWork : IUnitofWork
    {
        private readonly SarayContext dbContext;

        public EfUnitofWork(SarayContext _dbContext)
        {
            dbContext = _dbContext ?? throw new ArgumentNullException("dbcontext boş olamaz");
        }
        private IProductRepository _products;
        private ICategoryRepository _categories;



        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(dbContext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(dbContext));
            }
        }


        public void Dispose()
        {
            dbContext.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
