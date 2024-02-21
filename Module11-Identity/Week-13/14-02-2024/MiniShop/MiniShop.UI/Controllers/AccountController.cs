using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels.IdentityViewModels;

namespace MiniShop.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, RoleManager<Role> roleManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        //Burası kullanıcı profil sayfasını render edecek.
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Login(string returnUrl)
        {
            if(returnUrl != null)
            {
                TempData["ReturnUrl"]=returnUrl;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(loginViewModel.UserName);
                if (user == null)
                {
                    ModelState.AddModelError("", "Kullanıcı adı bulunamadı");
                    return View(loginViewModel);
                }
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password,false,false);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Parola hatalı");
                    return View(loginViewModel);
                }
                var returnUrl = TempData["ReturnUrl"]?.ToString();
                if (!String.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                return RedirectToAction("Index","Home");
            }
            return View(loginViewModel);
        }
    
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //return RedirectToAction("Index","Home");
            return Redirect("~/");
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    FirstName=registerViewModel.FirstName,
                    LastName=registerViewModel.LastName
                };
                var result = await _userManager.CreateAsync(newUser, registerViewModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(newUser,"Customer");
                    return Redirect("~/");
                }
            }
            return View(registerViewModel);
        }
    }
}
