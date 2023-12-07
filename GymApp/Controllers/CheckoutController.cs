using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GymApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class CheckoutController : Controller
    {
        private ICartItemService _cartItemService;
        private ICartService _cartService;
        private IShippingService _shippingService;
        private IOrderService _orderService;
        private IOrderDetailsService _orderDetailsService;
        private IUserService _userService;
        public CheckoutController(ICartItemService cartItemService, IShippingService shippingService, IOrderService orderService, 
            IOrderDetailsService orderDetailsService, ICartService cartService, IUserService userService)
        {
            _cartItemService = cartItemService;
            _shippingService = shippingService;
            _orderService = orderService;
            _orderDetailsService = orderDetailsService;
            _cartService = cartService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            var user = _userService.GetByUsername(User.Identity.Name);
            var cartItems = _cartItemService.GetAllByMemberUsername(User.Identity.Name);
            ShippingDetailsViewModel s = new ShippingDetailsViewModel()
            {
                FullName = user.FullName,
                Username= user.UserName,
                Email = user.Email,
                CartItems = cartItems
            };

            return View(s);
        }

        [HttpPost]
        public IActionResult Index(ShippingDetailsViewModel s)
        {
            var user = _userService.GetByUsername(User.Identity.Name);
            if (ModelState.IsValid)
            {
                Shipping shipping= new Shipping()
                {
                    FullName= user.FullName,
                    Username= user.UserName,
                    Email = user.Email,
                    Address = s.Address,
                    Country= s.Country,
                    City= s.City,
                    PostalCode= s.PostalCode,

                };

                _shippingService.Add(shipping);

                //Triggerla shipping eklendiğinde order eklenebilir

                Order o = new Order()
                {
                    OrderDate = DateTime.Now,
                    ShippingId = shipping.ShippingId,
                    
                   
                };

                _orderService.Add(o);


                var cartItems = _cartItemService.GetAllByMemberUsername(User.Identity.Name);

                foreach (var item in cartItems)
                {
                    OrderDetails od = new OrderDetails()
                    {
                        OrderId = o.OrderId,
                        PacketId = item.PacketId,
                    };

                    _orderDetailsService.Add(od);

                }

                _cartService.ClearCart(cartItems);

                TempData["Shipping"] = "true";

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CheckPromoCode(int code)
        {
            return RedirectToAction("Index");
        }

    }
}
