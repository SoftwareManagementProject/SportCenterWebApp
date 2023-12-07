using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymApp.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {

        private readonly ICategoryService _categoryService;
        private ICartItemService _cartItemService;

        public NavbarViewComponent(ICategoryService categoryService, ICartItemService cartItemService)
        {
            _categoryService = categoryService;
            _cartItemService = cartItemService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            ViewBag.numberOfCartItem = _cartItemService.GetAllByMemberUsername(User.Identity.Name).Count;


            return View(items);
        }

        private Task<List<Category>> GetItemsAsync()
        {
            return Task.FromResult(_categoryService!.GetAll());
        }
    }
}
