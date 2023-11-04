

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
        [Route("/Fitness/{id?}")]
        public IActionResult Fitness(int categoryId)
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
        [Route("/Kickbox/{id?}")]
        public IActionResult Kickbox(int categoryId)
        {

            var model = new CategoryDescriptionImageViewModel();

            var kickbox = _categoryService.GetWithDescriptionAndImageById(categoryId);
            model.CategoryId = kickbox.CategoryId;
            model.CategoryName = kickbox.CategoryName;
            model.CategoryInfo = kickbox.CategoryInfo;
            model.CategoryPrice = kickbox.CategoryPrice;
            model.CategoryDescriptions = kickbox.Descriptions!.Where(x => x.CategoryId == kickbox.CategoryId).Select(x => x.DescriptionName).ToList();
            model.CategoryImages = kickbox.Images!.Where(x => x.CategoryId == kickbox.CategoryId).Select(x => x.ImageName).ToList();

            return View(model);
        }

        [Route("/Pilates/{id?}")]
        public IActionResult Pilates(int categoryId)
        {
            var model = new CategoryDescriptionImageViewModel();

            var pilates = _categoryService.GetWithDescriptionAndImageById(categoryId);
            model.CategoryId = pilates.CategoryId;
            model.CategoryName = pilates.CategoryName;
            model.CategoryInfo = pilates.CategoryInfo;
            model.CategoryPrice = pilates.CategoryPrice;
            model.CategoryDescriptions = pilates.Descriptions!.Where(x => x.CategoryId == pilates.CategoryId).Select(x => x.DescriptionName).ToList();
            model.CategoryImages = pilates.Images!.Where(x => x.CategoryId == pilates.CategoryId).Select(x => x.ImageName).ToList();

            return View(model);
        }

        [Route("/Zumba/{id?}")]
        public IActionResult Zumba(int categoryId)
        {

            var model = new CategoryDescriptionImageViewModel();

            var zumba = _categoryService.GetWithDescriptionAndImageById(categoryId);
            model.CategoryId = zumba.CategoryId;
            model.CategoryName = zumba.CategoryName;
            model.CategoryInfo = zumba.CategoryInfo;
            model.CategoryPrice = zumba.CategoryPrice;
            model.CategoryDescriptions = zumba.Descriptions!.Where(x => x.CategoryId == zumba.CategoryId).Select(x => x.DescriptionName).ToList();
            model.CategoryImages = zumba.Images!.Where(x => x.CategoryId == zumba.CategoryId).Select(x => x.ImageName).ToList();

            return View(model);
        }

        [Route("/Coaching/{id?}")]
        public IActionResult Coaching(int categoryId)
        {
            var model = new CategoryDescriptionImageViewModel();

            var coaching = _categoryService.GetWithDescriptionAndImageById(categoryId);
            model.CategoryId = coaching.CategoryId;
            model.CategoryName = coaching.CategoryName;
            model.CategoryInfo = coaching.CategoryInfo;
            model.CategoryPrice = coaching.CategoryPrice;
            model.CategoryDescriptions = coaching.Descriptions!.Where(x => x.CategoryId == coaching.CategoryId).Select(x => x.DescriptionName).ToList();
            model.CategoryImages = coaching.Images!.Where(x => x.CategoryId == coaching.CategoryId).Select(x => x.ImageName).ToList();

            return View(model);
        }
    }
}