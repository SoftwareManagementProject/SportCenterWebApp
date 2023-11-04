

using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GymApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GymApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICategoryService _categoryService;
        private ITrainerService _trainerService;
        private IContactService _contactService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, ITrainerService trainerService,
            IContactService contactService
            )
        {
            _logger = logger;
            _categoryService = categoryService;
            _trainerService = trainerService;
            _contactService = contactService;
        }

        public IActionResult Index()
        {

            var categories = _categoryService.GetAllWithDescriptionAndImage().Select(i => new CategoryDescriptionImageViewModel
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                CategoryInfo = i.CategoryInfo,
                CategoryPrice = i.CategoryPrice, //AQ entityframeworkcoru navigation props çalışmıyor.
                                                 //Not: Include method kullanmak gerekiyormuş Sorry entito
                CategoryDescriptions = i.Descriptions!.Where(x => x.CategoryId == i.CategoryId).Select(x => x.DescriptionName).ToList(),
                CategoryImages = i.Images!.Where(x => x.CategoryId == i.CategoryId).Select(x => x.ImageName).ToList()
            }).ToList();

            return View(categories);
        }


        [Route("/Trainers")]
        public IActionResult Trainers()
        {
            var trainers = _trainerService.GetAll();
            return View(trainers);
            
        }

        [Route("/About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/Contact")]
        public IActionResult Contact()
        {
            
            return View();
        }

        public IActionResult Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View("Index");
            }

            var category = _categoryService.GetByName(query);
            if (category != null)
            {
                return RedirectToAction(string.Format("{0}", category.CategoryName), "Home", new { categoryId = category.CategoryId });
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Route("/Contact")]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid) 
            {
                _contactService.Add(contact);
                return RedirectToAction("Index", "Home");
            }
            
            return View();
        }

        [Route("/Sport/{id?}")]
        public IActionResult Sport(int categoryId)
        {
            var model = new CategoryDescriptionImageViewModel();

            var fitness = _categoryService.GetWithDescriptionAndImageById(categoryId);
            model.CategoryId = fitness.CategoryId;
            model.CategoryName = fitness.CategoryName;
            model.CategoryInfo = fitness.CategoryInfo;
            model.CategoryPrice = fitness.CategoryPrice;
            model.CategoryDescriptions = fitness.Descriptions!.Where(x => x.CategoryId == fitness.CategoryId).Select(x => x.DescriptionName).ToList();
            model.CategoryImages = fitness.Images!.Where(x => x.CategoryId == fitness.CategoryId).Select(x => x.ImageName).ToList();


            return View(model);
        }


    }
}