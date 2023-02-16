using System.ComponentModel.DataAnnotations;

namespace Business.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Password { get; set; }
    }
}
