using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.EfCore.Contexts;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(MiniShopDbContext miniShopDbContext):base(miniShopDbContext)
        {
            
        }

        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext;}
        }

        public async Task<List<Category>> GetAllNonDeletedAsync(bool isDeleted = false)
        {
            var categories = await MiniShopDbContext
                .Categories
                .Where(c => c.IsDeleted == isDeleted)
                .ToListAsync();
            return categories;
        }
    }
}
