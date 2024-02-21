using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartManager;
        private readonly ICartItemService _cartItemManager;
        private readonly IOrderService _orderManager;

        public CartController(UserManager<User> userManager, ICartService cartManager, ICartItemService cartItemManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _cartManager = cartManager;
            _cartItemManager = cartItemManager;
            _orderManager = orderManager;
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

        public async Task<IActionResult> ChangeQuantity(int id, int quantity)
        {
            await _cartItemManager.ChangeQuantityAsync(id, quantity>0 ? quantity : 1);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveItem(int id)
        {
            await _cartItemManager.DeleteItemFromCartAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> CheckOut()
        {
            var userId = _userManager.GetUserId(User);
            var cart = await _cartManager.GetCartByUserIdAsync(userId);
            //Satış işlemleri ile ilgili entity yapılarımızı hazırlamaya gidiyoruz.
            OrderViewModel orderViewModel = new OrderViewModel
            {
                FirstName = "Sezen",
                LastName = "Aksu",
                Address = "İzmir yolu, İzmir cad No:12",
                City = "İzmir",
                PhoneNumber = "4553332211",
                Email = "sezenaksu@gmail.com",
                Note = "Lütfen zile basmayın",
                CardName = "Sezen Aksu",
                CardNumber = "5890040000000016",
                ExpirationMonth = "7",
                ExpirationYear = "2028",
                Cvc = "345",
            };
            orderViewModel.Cart = cart;

            return View(orderViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CheckOut(OrderViewModel orderViewModel)
        {
            var userId = _userManager.GetUserId(User);
            var cart = await _cartManager.GetCartByUserIdAsync(userId);
            orderViewModel.Cart = cart;
            if(ModelState.IsValid) 
            {
                //Ödeme İşlemi
                //Iyzico API seçenekleri oluşturuluyor
                Options options = new Options();
                options.ApiKey = "sandbox-zkYUNw2G0R4r0Tx56FCSoci35BkP0Klu";
                options.SecretKey = "sandbox-NIOVoXht6EYjlZFMtDINXzDq77Gcpj1H";
                options.BaseUrl = "https://sandbox-api.iyzipay.com";

                //Iyzico ödeme nesnesi yaratılıyor
                CreatePaymentRequest request = new CreatePaymentRequest();
                request.Locale = Locale.EN.ToString();
                request.ConversationId = "1";
                request.Price = cart.TotalPrice().ToString().Replace(",",".");
                request.PaidPrice =cart.TotalPrice().ToString().Replace(",", ".");
                request.Currency = Currency.TRY.ToString();
                request.Installment = 1;
                request.BasketId = cart.Id.ToString();
                request.PaymentChannel = PaymentChannel.WEB.ToString();  
                request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

                //Ödeme aracı(kart) bilgileri yaratılıyor
                PaymentCard paymentCard = new PaymentCard();
                paymentCard.CardHolderName = orderViewModel.CardName;
                paymentCard.CardNumber = orderViewModel.CardNumber;
                paymentCard.ExpireMonth = orderViewModel.ExpirationMonth;
                paymentCard.ExpireYear = orderViewModel.ExpirationYear;
                paymentCard.Cvc = orderViewModel.Cvc;
                paymentCard.RegisterCard = 0;

                request.PaymentCard = paymentCard;

                //Alıcı bilgileri oluşturuluyor
                Buyer buyer = new Buyer();
                buyer.Id = userId;
                buyer.Name = orderViewModel.FirstName;
                buyer.Surname = orderViewModel.LastName;
                buyer.GsmNumber = orderViewModel.PhoneNumber;
                buyer.Email = orderViewModel.Email;
                buyer.IdentityNumber = "74300864791";
                buyer.LastLoginDate = "2015-10-05 12:43:35";
                buyer.RegistrationDate = "2013-04-21 15:12:09";
                buyer.RegistrationAddress = orderViewModel.Address;
                buyer.Ip = "85.34.78.112";
                buyer.City = orderViewModel.City;
                buyer.Country = "Türkiye";
                buyer.ZipCode = "34732";

                request.Buyer = buyer;

                //Adresler yaratılıyor
                Address shippingAddress = new Address();
                shippingAddress.ContactName = "Jane Doe";
                shippingAddress.City = "Istanbul";
                shippingAddress.Country = "Turkey";
                shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
                shippingAddress.ZipCode = "34742";
                request.ShippingAddress = shippingAddress;

                Address billingAddress = new Address();
                billingAddress.ContactName = "Jane Doe";
                billingAddress.City = "Istanbul";
                billingAddress.Country = "Turkey";
                billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
                billingAddress.ZipCode = "34742";
                request.BillingAddress = billingAddress;

                //Sepet nesnesi yaratılıp, itemlar dolduruluyor
                List<BasketItem> basketItems = new List<BasketItem>();
                BasketItem basketItem;
                foreach (var item in cart.CartItems)
                {
                    basketItem= new BasketItem();
                    basketItem.Id = item.Id.ToString();
                    basketItem.Name = item.Product.Name;
                    basketItem.Category1 = "General";
                    basketItem.Category2 = "";
                    basketItem.ItemType = BasketItemType.PHYSICAL.ToString(); 
                    basketItem.Price = (item.Quantity*item.Product.Price).ToString().Replace(",", ".");
                    basketItems.Add(basketItem);
                }
                request.BasketItems=basketItems;

                Payment payment = Payment.Create(request, options);
                if (payment.Status == "success")
                {
                    //Sipariş kaydı(Eğer ödeme başarıyla tamamlandıysa)
                    Order order = new Order
                    {
                        OrderNumber = new Random().Next(111111111, 999999999).ToString(),
                        UserId = userId,
                        OrderState = EnumOrderStateType.Waiting,
                        PaymentType = EnumPaymentType.CreditCard,
                        PaymentId = "1",
                        ConversationId = "1",
                        OrderDate = DateTime.Now,
                        FirstName = orderViewModel.FirstName,
                        LastName = orderViewModel.LastName,
                        Address = orderViewModel.Address,
                        City = orderViewModel.City,
                        Email = orderViewModel.Email,
                        PhoneNumber = orderViewModel.PhoneNumber,
                        Note = orderViewModel.Note,
                        OrderDetails = cart.CartItems.Select(ci => new OrderDetail
                        {
                            ProductId = ci.ProductId,
                            Price = ci.Product.Price,
                            Qauntity = ci.Quantity
                        }).ToList()
                    };
                    await _orderManager.CreateAsync(order);
                    await _cartItemManager.ClearCartAsync(cart.Id);
                    return Redirect("~/");
                }
                ModelState.AddModelError("", payment.ErrorMessage);
            }

            //Ödeme ile ilgili hata varsa burada yazabiliriz.
            return View(orderViewModel);
        }
    }
}


//api key: sandbox-zkYUNw2G0R4r0Tx56FCSoci35BkP0Klu
//secret key: sandbox-NIOVoXht6EYjlZFMtDINXzDq77Gcpj1H