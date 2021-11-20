using System.ComponentModel.DataAnnotations;

namespace EducateAPP.ViewModels.TypeOfTotal
{
    public class CreateTypeOfTotalViewModel
    {
        [Required(ErrorMessage = "Введите название аттестации")]
        [Display(Name = "Аттестация")]
        public string CertificateName { get; set; }
    }
}
