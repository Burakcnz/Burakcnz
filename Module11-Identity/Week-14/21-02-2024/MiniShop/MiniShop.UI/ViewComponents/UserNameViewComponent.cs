using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.ViewComponents
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;

        public UserNameViewComponent(IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            var userFullName = $"{user.FirstName} {user.LastName}";
            return View("Default",userFullName);
        }
    }
}
