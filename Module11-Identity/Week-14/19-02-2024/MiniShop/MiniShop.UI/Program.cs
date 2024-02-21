using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.Helpers.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MiniShopDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<MiniShopDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region Parola Ayarlar�

    options.Password.RequiredLength = 6; //Parola uzunlu�u
    options.Password.RequireDigit = true; //Rakam i�ersin mi?
    options.Password.RequireNonAlphanumeric = true; //�zel karakter i�ersin mi?
    options.Password.RequireUppercase = true; //B�y�k harf i�ersin mi?
    options.Password.RequireLowercase = true; //K���k harf i�ersin mi?
                                              //options.Password.RequiredUniqueChars = 2; //Karakterlerin tekrar adedi

    #endregion

    #region Hesap Kilitleme Ayarlar�

    options.Lockout.MaxFailedAccessAttempts = 3; //Hatal� giri� denemesi s�n�r�
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15); //Hesap kilitlendikten ne kadar s�re sonra yeniden giri� yap�labilir

    #endregion

    #region Di�er Ayarlar

    options.User.RequireUniqueEmail = true; //bir mail adresi ile sadece bir hesap olu�turuabilir.
    options.SignIn.RequireConfirmedEmail = false; //Kay�t i�lemi email onay� gerektirsin mi?

    #endregion
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromDays(100);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        Name="InfoTech.MiniShop.Security.Cookie",
        SameSite=SameSiteMode.Strict,
        HttpOnly=true
    };

});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICartService, CartManager>();
builder.Services.AddScoped<ICartItemService, CartItemManager>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<ICartItemRepository, CartItemRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IImageHelper, ImageHelper>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
