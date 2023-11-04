using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator() 
        {
            RuleFor(i => i.MemberNameSurname).NotEmpty().WithMessage("Adınızı ve soyadınızı giriniz");
            RuleFor(i => i.MemberUserName).NotEmpty().WithMessage("Kullanıcı adınızı giriniz");
            RuleFor(i => i.MemberEmail).NotEmpty().WithMessage("Mail adresi giriniz");
            RuleFor(i => i.MemberPassword).NotEmpty().WithMessage("Password giriniz");
            RuleFor(i => i.MemberPassword).MinimumLength(8).WithMessage("Şifre en az 8 karaktere sahip olmalıdır.");
        }
    }
}
