using Business.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.IServicesGeneric
{
    public interface IRegisterUser
    {
        Task<ActionResult> Register(RegisterViewModel register);
        Task<ActionResult> Login(LoginViewModel login);
    }
}
