using Microsoft.AspNetCore.Mvc;

namespace MiniShopUI.Areas.Admin.ViewComponents
{
    public class NavbarNotificationsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
