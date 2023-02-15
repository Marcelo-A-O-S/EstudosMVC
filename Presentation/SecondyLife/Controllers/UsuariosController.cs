using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecondyLife.ViewModel;

namespace SecondyLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpPost]
        public ActionResult Registro()
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
            return Ok();
        }
    }
}
