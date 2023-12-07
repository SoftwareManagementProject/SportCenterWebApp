using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GymApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartItemService _cartItemService;
        private IPacketService _packetService;
        public CartController(ICartService cartService, ICartItemService cartItemService, IPacketService packetService)
        {
            _cartService = cartService;
            _cartItemService = cartItemService;
            _packetService = packetService;
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
            var userPackets = _packetService.GetAllByUsername(User.Identity.Name);
            var newPacket = _packetService.GetById(packetId);
            
            if (!userPackets.Exists(i => i.PacketType == newPacket.PacketType))
            {
                if (_cartItemService.CheckIfPacketNotExistBefore(packetId, cart.CartId))
                {
                    CartItem cartItem = new CartItem()
                    {
                        PacketId = packetId,
                        CartId = cart.CartId
                    };

                    _cartItemService.Add(cartItem);

                    return RedirectToAction("Index");
                }

                TempData["packet"] = "ExistInCart";

            }
            else
            {
                TempData["packet"] = "ExistInPackets";
            }


            return RedirectToAction("Index", "Home");
            

        }

        public IActionResult RemoveFromCart(int cartItemId)
        {
            var cartItem = _cartItemService.GetById(cartItemId);
            _cartItemService.Delete(cartItem);

            return RedirectToAction("Index");
        }

    }
}
