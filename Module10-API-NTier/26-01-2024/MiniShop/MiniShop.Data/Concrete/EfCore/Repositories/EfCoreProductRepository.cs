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
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(MiniShopDbContext miniShopDbContext):base(miniShopDbContext)
        {
            
        }

        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            var products = await MiniShopDbContext
                .Products
                .Where(p => p.IsHome && p.IsActive && !p.IsDeleted)
                .ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetNonDeletedProductsAsync(bool isDeleted = false)
        {
            var products = await MiniShopDbContext
                .Products
                .Where(p=>p.IsDeleted==isDeleted)
                .ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var products = await MiniShopDbContext
                .Products
                .Include(p=>p.ProductCategories)
                .ThenInclude(pc=>pc.Category)
                .Where(p=>p.ProductCategories.Any(pc=>pc.CategoryId==categoryId))
                .ToListAsync();
            return products;
        }

        public async Task<Product> GetProductWithCategoriesAsync(int id)
        {
            var product = await MiniShopDbContext
                .Products
                .Where(p=>p.Id==id)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .SingleOrDefaultAsync();
            return product;
        }
    }
}
