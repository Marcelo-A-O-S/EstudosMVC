using Business.Services.IServicesGeneric;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.ViewModel;
using Microsoft.AspNetCore.Identity;
using ModelDomain.Models;
using ModelDomain.Enum;
using Business.Repository.Interfaces;
using Business.Services;

namespace SecondyLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase, IRegisterUser
    {
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;
        private readonly GerenciadorEndereco _endereco;
        //private readonly TesteEndereco<Endereco> testeEndereco;

        public AuthenticationController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, GerenciadorEndereco endereco )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this._endereco = endereco;
            //this.testeEndereco = testeEndereco;
        }
        [HttpPost]
        [Route("Login")]
        public Task<ActionResult> Login(LoginViewModel login)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [Route("Teste")]
        public async Task<string> Teste()
        {
            try
            {
                var retorno = "";
                var list = await _endereco.GetAll();
                if(list == null)
                {
                    return "List retornou null";
                }
                foreach( var item in list)
                {
                    retorno = item.Cidade;
                }
                return retorno;
            }
            catch(Exception erro)
            {
                return erro.Message;
            }
            
            
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
                    EmailConfirmed = true,
                    tipoUsuario = TipoUsuario.Usuario
                };
                
                var result = await userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    user = await userManager.FindByEmailAsync(register.Email);
                    var endereco = new Endereco
                    {
                        Cidade = register.City,
                        Bairro = register.Region,
                        Rua = register.Street,
                        NumeroDaCasa = register.NumberHouse,
                        UsuarioId = user.Id,
                    };
                    _endereco.Add(endereco);
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
            return BadRequest();

        }
    }
}
