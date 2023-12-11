

using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GymApp.Models;
using Microsoft.AspNetCore.Mvc;
using OpenAI_API.Completions;
using OpenAI_API;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using OpenAI_API.Chat;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace GymApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICategoryService _categoryService;
        private ITrainerService _trainerService;
        private IContactService _contactService;
        private IPacketService _packetService;
        
        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, ITrainerService trainerService,
            IContactService contactService, IPacketService packetService
            )
        {
            _logger = logger;
            _categoryService = categoryService;
            _trainerService = trainerService;
            _contactService = contactService;
            _packetService = packetService;

        }

        public IActionResult Index()
        {

            var categories = _categoryService.GetAllWithDescriptionAndImage().Select(i => new CategoryDescriptionImageViewModel
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                CategoryInfo = i.CategoryInfo,
                CategoryPrice = i.CategoryPrice, 
                CategoryDescriptions = i.Descriptions!.Where(x => x.CategoryId == i.CategoryId).Select(x => x.DescriptionName).ToList(),
                CategoryImages = i.Images!.Where(x => x.CategoryId == i.CategoryId).Select(x => x.ImageName).ToList()
            }).ToList();

            ViewBag.packet = TempData["packet"] as string;
            ViewBag.Shipping = TempData["Shipping"] as string;

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

        [HttpPost]
        [Route("/Contact")]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(contact);
                Thread.Sleep(3000);
                
                return RedirectToAction("Index", "Home");
            }

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
                return RedirectToAction("Sport", "Home", new { categoryId = category.CategoryId });
            }
            return RedirectToAction("Index", "Home");
        }



        [Route("/Sport/{id?}")]
        public IActionResult Sport(int categoryId)
        {
            var model = new CategoryDescriptionImageViewModel();

            var sport = _categoryService.GetWithDescriptionAndImageById(categoryId);
            model.CategoryId = sport.CategoryId;
            model.CategoryName = sport.CategoryName;
            model.CategoryInfo = sport.CategoryInfo;
            model.CategoryPrice = sport.CategoryPrice;
            model.CategoryDescriptions = sport.Descriptions!.Where(x => x.CategoryId == sport.CategoryId).Select(x => x.DescriptionName).ToList();
            model.CategoryImages = sport.Images!.Where(x => x.CategoryId == sport.CategoryId).Select(x => x.ImageName).ToList();


            return View(model);
        }

        [Route("/{username?}/Packets")]
        public IActionResult Packets()
        {
            var packets = _packetService.GetAllByUsername(User.Identity.Name);
            return View(packets);
        }

        public async Task<IActionResult> ChatBot(string prompt)
        {

            if(ModelState.IsValid)
            {
                string apiKey = "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";
                var openai = new OpenAIAPI(apiKey);

                ChatRequest chat = new ChatRequest()
                {
                    Messages= new List<ChatMessage>()
                    {
                        new ChatMessage(ChatMessageRole.User, prompt)
                    },
                    Model = "gpt-3.5-turbo",
                    MaxTokens= 100,
                };

                var result = await openai.Chat.CreateChatCompletionAsync(chat);

                if (result != null)
                {
                    var answer = result.Choices[0].Message.Content;
                    var jsonAnswer = JsonConvert.SerializeObject(answer);
                    return Json(jsonAnswer);
                }
                else
                {
                    var answer = "I don't have any idea";
                    return Json(answer);
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult GetChatBot()
        {
            return PartialView("ChatBotPartial");
        }

    }
}