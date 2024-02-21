using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels.IdentityViewModels;

namespace MiniShop.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ICartService _cartManager;

        public AccountController(UserManager<User> userManager, RoleManager<Role> roleManager, SignInManager<User> signInManager, ICartService cartManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _cartManager = cartManager;
        }

        //Burası kullanıcı profil sayfasını render edecek.
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Login(string returnUrl=null)
        {
            return View(new LoginViewModel { ReturnUrl=returnUrl});
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

                return Redirect(loginViewModel.ReturnUrl ?? "~/");
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
                    await _cartManager.InitializeCartAsync(newUser.Id);
                    return RedirectToAction("Login");
                }
            }
            return View(registerViewModel);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
