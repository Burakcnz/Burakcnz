using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.ViewComponents
{
    public class CartNotificationViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartManager;
        private readonly ICartItemService _cartItemManager;

        public CartNotificationViewComponent(IHttpContextAccessor httpContextAccessor, UserManager<User> userManager, ICartService cartManager, ICartItemService cartItemManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _cartManager = cartManager;
            _cartItemManager = cartItemManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            var cart = await _cartManager.GetCartByUserIdAsync(userId);
            var count = await _cartItemManager.ItemCountAsync(cart.Id);
            return View(count);
        }
    }
}
