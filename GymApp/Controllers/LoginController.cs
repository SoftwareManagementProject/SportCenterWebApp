using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using GymApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Security.Claims;

namespace GymApp.Controllers
{
    [AllowAnonymous]
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
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            //var member = _memberService.GetByEmailAndPassword(model.Email, model.Password);
            //if (member != null)
            //{
            //    //HttpContext.Session.SetString("username", model.Email);
            //    var claims = new List<Claim>
            //    {
            //        new Claim(ClaimTypes.Name, member.MemberEmail)
            //    };

            //    var userIdentity = new ClaimsIdentity(claims, "a");
            //    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            //    await HttpContext.SignInAsync(principal);
            //    return RedirectToAction("Index", "Member");
            //}
            return View();

        }
    }
}
