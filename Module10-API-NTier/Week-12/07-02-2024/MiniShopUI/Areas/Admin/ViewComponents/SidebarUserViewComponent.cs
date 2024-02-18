using Microsoft.AspNetCore.Mvc;

namespace MiniShopUI.Areas.Admin.ViewComponents
{
    public class SidebarUserViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string userFullName = "Admin Yöneticioğlu";
            return View("Default",userFullName);
        }
    }
}
