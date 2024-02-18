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
        
        public async Task<List<Product>> GetDeletedAndActiveProductsAsync(bool isDeleted = false, bool? isActive=null)
        {
            var products = MiniShopDbContext
                .Products
                .Where(p => p.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                products=products
                    .Where(p=>p.IsActive==isActive);
            }
            return await products.ToListAsync();
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

        public async Task ClearProductCategory(int productId)
        {
            List<ProductCategory> productCategories = await MiniShopDbContext
                .ProductCategories
                .Where(pc=>pc.ProductId==productId)
                .ToListAsync();
            MiniShopDbContext.ProductCategories.RemoveRange(productCategories);
            await MiniShopDbContext.SaveChangesAsync();

        }
    }
}
