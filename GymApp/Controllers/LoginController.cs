using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using GymApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;


namespace GymApp.Controllers
{
    public class LoginController : Controller
    {
        private IMemberService _memberService;

        public LoginController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {

            return View();
        }
    }
}
