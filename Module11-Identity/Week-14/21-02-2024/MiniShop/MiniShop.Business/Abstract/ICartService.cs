using MiniShop.Entity.Concrete;
using MiniShop.Shared.ResponseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface ICartService
    {
        Task InitializeCartAsync(string userId);
        Task<Cart> GetCartByUserIdAsync(string userId);
        
    }
}
