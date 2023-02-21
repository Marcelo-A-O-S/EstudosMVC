using Business.Services.IServicesGeneric;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.ViewModel;
using Microsoft.AspNetCore.Identity;
using ModelDomain.Models;
using ModelDomain.Enum;
using Business.Repository.Interfaces;
using Business.Services;
using Business.TokenJWT.ITokenJWT;

namespace SecondyLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase, IRegisterUser
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> signInManager;
        private readonly GerenciadorEndereco _endereco;
        private readonly ITokenJwt _jwt;
        private readonly DataAuthentication autenticacao;

        //private readonly TesteEndereco<Endereco> testeEndereco;

        public AuthenticationController(
            UserManager<Usuario> userManager, 
            SignInManager<Usuario> signInManager, 
            GerenciadorEndereco endereco, 
            ITokenJwt jwt, 
            DataAuthentication autenticacao )
        {
            this._userManager = userManager;
            this.signInManager = signInManager;
            this._endereco = endereco;
            this._jwt = jwt;
            this.autenticacao = autenticacao;
            //this.testeEndereco = testeEndereco;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(LoginViewModel login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.FindByEmailAsync(login.Email);
                    var result = await signInManager.CheckPasswordSignInAsync(user, login.Password, false);
                    if(result.Succeeded == true)
                    {
                        result = await signInManager.PasswordSignInAsync(login.Email, login.Password, false, lockoutOnFailure: false);
                        if (result.Succeeded == true)
                        {
                            user.statusUsuario = StatusUsuario.online;
                            var userData = new UserData
                            {
                                Email = user.Email,
                                userName = user.UserName,

                            };
                            if(user.statusUsuario != StatusUsuario.online)
                            {
                                user.statusUsuario = StatusUsuario.online;
                                userData.Status = true;
                                if (user.tipoUsuario != TipoUsuario.Usuario)
                                {
                                    userData.Role = "Admin";
                                }
                                else
                                {
                                    userData.Role = "User";
                                }
                                userData.TokenJwt = _jwt.CreateToken(userData);
                                var auth = new Autenticacao
                                {
                                    TokenJwt = userData.TokenJwt,
                                    UsuarioId = user.Id,
                                };
                                await _userManager.UpdateAsync(user);
                                autenticacao.Add(auth);
                            }
                            return Ok(userData);

                        }
                        else
                        {
                            return NotFound("Usuário não registrado ou informações incorretas!");
                        }
                    }
                    else
                    {
                        return BadRequest("Senha incorreta, corrija e tenta novamente!");
                    }
                }
                else
                {
                    return BadRequest("Corrija as informações!");
                }
            }
            catch(Exception erro)
            {
                return BadRequest(erro.Message);
            }
            
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
                    tipoUsuario = TipoUsuario.Usuario,
                    
                };
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded == true)
                {
                    user = await _userManager.FindByEmailAsync(register.Email);
                    var endereco = new Endereco
                    {
                        Cidade = register.City,
                        Bairro = register.Region,
                        Rua = register.Street,
                        NumeroDaCasa = register.NumberHouse,
                        UsuarioId = user.Id,
                    };
                    _endereco.Add(endereco);
                    user.statusUsuario = StatusUsuario.online;
                    var userData = new UserData
                    {
                        Email = user.Email,
                        userName = user.UserName,

                    };
                    if (user.statusUsuario != StatusUsuario.online)
                    {
                        user.statusUsuario = StatusUsuario.online;
                        userData.Status = true;
                        userData.Role = "User";
                        userData.TokenJwt = _jwt.CreateToken(userData);
                        var auth = new Autenticacao
                        {
                            TokenJwt = userData.TokenJwt,
                            UsuarioId = user.Id,
                        };
                        await _userManager.UpdateAsync(user);
                        autenticacao.Add(auth);
                    }
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return Ok(userData);
                }
                else
                {
                    
                    foreach(var erro in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erro.Description);
                    }
                    return BadRequest(ModelState);
                    
                }
            }
            return BadRequest();

        }
    }
}
