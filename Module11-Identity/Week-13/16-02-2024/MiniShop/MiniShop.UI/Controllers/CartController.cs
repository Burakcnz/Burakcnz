using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartManager;
        private readonly ICartItemService _cartItemManager;

        public CartController(UserManager<User> userManager, ICartService cartManager, ICartItemService cartItemManager)
        {
            _userManager = userManager;
            _cartManager = cartManager;
            _cartItemManager = cartItemManager;
        }

        //Sepeti görüntülemek için kullanılacak action
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            if(userId!=null)
            {
                Cart cart = await _cartManager.GetCartByUserIdAsync(userId);
                if(cart!=null)
                {
                    return View(cart);
                }
            }
            return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> AddToCart(int id, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            if (userId != null)
            {
                await _cartItemManager.AddCartItemToCartAsync(userId, id, quantity);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> ChangeQuantity(CartItem cartItem)
        {

            return View();
        }
    }
}
