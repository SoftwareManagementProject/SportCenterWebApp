using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using GymApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Security.Claims;

namespace GymApp.Controllers
{

    public class LoginController : Controller
    {
        private IUserService _userService;
        private SignInManager<AppUser> _signInManager;

        public LoginController(IUserService userService, SignInManager<AppUser> signInManager)
        {
            _userService = userService;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            return View();
            

        }
    }
}
