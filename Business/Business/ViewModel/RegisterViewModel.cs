using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [PasswordPropertyText]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "Os senhas não batem, corrija para poder prosseguir")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string PasswordConfirmed { get; set; }

        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int NumberHouse { get; set; }
    }
}
