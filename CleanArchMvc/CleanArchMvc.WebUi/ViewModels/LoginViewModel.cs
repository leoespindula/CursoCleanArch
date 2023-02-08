using System.ComponentModel.DataAnnotations;

namespace CleanArchMvc.WebUi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email é requerido")]
        [EmailAddress(ErrorMessage = "O formato do Email é invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é requerido")]
        [StringLength(20, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
