using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymApp.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {

        private readonly ICategoryService _categoryService;

        public NavbarViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<List<Category>> GetItemsAsync()
        {
            return Task.FromResult(_categoryService!.GetAll());
        }
    }
}
