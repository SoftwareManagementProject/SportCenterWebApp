using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.ViewComponents
{
    public class SportPacketsViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;
        private IPacketService _packetService;
        public SportPacketsViewComponent(ICategoryService categoryService, IPacketService packetService)
        {
            _categoryService = categoryService;
            _packetService = packetService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            ViewBag.Packets = _packetService.GetAll();
            return View(items);
        }

        public async Task<List<Category>> GetItemsAsync()
        {
            var categories = _categoryService.GetAllWithPackets();
            return await Task.FromResult(categories);
        }
    }
}
