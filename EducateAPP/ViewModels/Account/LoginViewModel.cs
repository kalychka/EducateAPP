using System.ComponentModel.DataAnnotations;

namespace EducateAPP.ViewModels.Account
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Введите e-mail")]
        [Display(Name = "e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ввкдите пароль")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
