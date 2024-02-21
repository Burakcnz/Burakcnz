using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class CartManager : ICartService
    { 
        private readonly ICartRepository _cartRepository;

        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<Cart> GetCartByUserIdAsync(string userId)
        {
            Cart cart = await _cartRepository.GetByIdAsync(x=>x.UserId== userId, source=>source
                .Include(x=>x.CartItems)
                .ThenInclude(y=>y.Product)
                );
            return cart;
        }

        public async Task InitializeCartAsync(string userId)
        {
            Cart cart = new Cart { UserId = userId};
            await _cartRepository.CreateAsync(cart);
        }
    }
}
