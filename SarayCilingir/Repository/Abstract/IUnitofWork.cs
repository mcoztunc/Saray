using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarayCilingir.Repository.Abstract
{
   public interface IUnitofWork :IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }

        int SaveChanges();

    }
}
