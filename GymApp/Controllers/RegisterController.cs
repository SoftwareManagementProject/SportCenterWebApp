using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private IMemberService _memberService;
        
        public RegisterController(IMemberService memberService) 
        {
            _memberService= memberService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Member member)
        {
            MemberValidator memberValidator = new MemberValidator();
            ValidationResult results = memberValidator.Validate(member);
            if(results.IsValid)
            {
                member.MemberStatus = true;
                _memberService.Add(member);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
