using System.ComponentModel.DataAnnotations;

namespace GymApp.Models
{
    public class RegisterViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage="Lütfen ad soyad giriniz")]
        public string FullName { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kulllanıcı adı giriniz")]
        public string Username { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Email { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrarı")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
