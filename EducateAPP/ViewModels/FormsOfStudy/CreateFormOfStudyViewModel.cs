using System.ComponentModel.DataAnnotations;

namespace EducateAPP.ViewModels.FormsOfStudy
{
    public class CreateFormOfStudyViewModel
    {
        [Required(ErrorMessage = "Введите название формы обучения")]
        [Display(Name = "Форма обучения")]
        public string FormOfEdu { get; set; }
    }
}