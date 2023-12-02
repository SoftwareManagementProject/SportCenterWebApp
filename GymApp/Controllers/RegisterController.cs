using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using GymApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private IMemberService _memberService;
        private UserManager<AppUser> _userManager;
        
        public RegisterController(IMemberService memberService, UserManager<AppUser> userManager) 
        {
            _memberService= memberService;
            _userManager= userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    UserName = model.Username
                };
                
                var result = await _userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    Member member = new Member()
                    {
                        MemberEmail = model.Email,
                        MemberUserName = model.Username,
                        MemberNameSurname = model.FullName,
                        MemberPassword = model.Password,
                        MemberStatus = true
                    };

                    _memberService.Add(member);
                    return RedirectToAction("Index", "Login");
                }
                return View(model);

            }
            return View();

        }
    }
}
