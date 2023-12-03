using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartItemService _cartItemService;
        public CartController(ICartService cartService, ICartItemService cartItemService)
        {
            _cartService = cartService;
            _cartItemService = cartItemService;

        }

        public IActionResult Index()
        {
            var cartItems = _cartItemService.GetAllByMemberUsername(User.Identity.Name);
            ViewBag.TotalPrice = cartItems.Select(i => i.Packet.PacketPrice).Sum();
            return View(cartItems);
        }
        public IActionResult AddToCart(int packetId) 
        {
            var cart = _cartService.GetByMemberUsername(User.Identity.Name);

            if(_cartItemService.CheckIfPacketNotExistBefore(packetId, cart.CartId))
            {
                CartItem cartItem = new CartItem()
                {
                    PacketId = packetId,
                    CartId = cart.CartId
                };

                _cartItemService.Add(cartItem);

                return RedirectToAction("Index");
            }


            return RedirectToAction("Index", "Home");
            

        }

        public IActionResult RemoveFromCart(int cartItemId)
        {
            var cartItem = _cartItemService.GetById(cartItemId);
            _cartItemService.Delete(cartItem);

            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
