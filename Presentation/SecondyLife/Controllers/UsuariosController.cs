using Business.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.ViewModel;
using Microsoft.AspNetCore.Identity;
using ModelDomain.Models;

namespace SecondyLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase, IRegisterUser
    {
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;

        public UsuariosController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpPost]
        [Route("Login")]
        public Task<ActionResult> Login(LoginViewModel login)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                var user = new Usuario
                {
                    UserName = register.Name,
                    Email = register.Email,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    
                }
                else
                {
                    
                    foreach(var erro in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erro.Description);
                        //Erro += erro.Description + " \n";
                    }
                    return BadRequest(ModelState);
                    
                }
            }
            throw new NotImplementedException();
        }
    }
}
