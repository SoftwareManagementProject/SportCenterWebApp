
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    public class CategoryController : Controller
    {
        
        public CategoryController() 
        {
            
        }
        public IActionResult Index()
        {   
            return View();
        }
    }
}
