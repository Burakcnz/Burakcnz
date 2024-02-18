using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface ICartItemService
    {
        Task AddCartItemToCartAsync(string userId, int productId, int quantity);
        Task ClearCartAsync(int cartId);
        Task DeleteItemFromCartAsync(int cartId, int productId);
        Task ChangeQuantityAsync(int cartItemId,  int quantity);
        Task<int> ItemCountAsync(int cartId);
    }
}
