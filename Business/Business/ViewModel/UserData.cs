using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModel
{
    public class UserData
    {
        public string userName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
        public string TokenJwt { get; set; }
        public string RefreshTokenJwt { get; set; }
    }
}
