using Business.Services.IServices;
using Business.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class RegisterUser : IRegisterUser
    {
        public Task<ActionResult> Login(LoginViewModel login)
        {
            throw new NotImplementedException();
        }

        Task<ActionResult> IRegisterUser.Register(RegisterViewModel register)
        {
            throw new NotImplementedException();
        }
    }
}
