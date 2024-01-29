using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        //Product entitysine özel metot imzaları
        Task<Product> GetProductWithCategoriesAsync(int id);
        Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId);
        Task<List<Product>> GetNonDeletedProductsAsync(bool isDeleted = false);
        Task<List<Product>> GetHomePageProductsAsync();

    }
}
