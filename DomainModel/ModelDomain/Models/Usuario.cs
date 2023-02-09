using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomain.Models
{
	public class Usuario : IdentityUser
    {
		public int Id { get; set; }
        [ForeignKey("Autenticacao")]
        public int AutenticacaoId { get; set; }
        public Autenticacao Autenticacao { get; set; }
        //public  string UserName { get; set; }

        
        //public  string NormalizedUserName { get; set; }

    
        //public  string Email { get; set; }

        
        //public string NormalizedEmail { get; set; }

        
        //public  bool EmailConfirmed { get; set; }

        
        //public string PasswordHash { get; set; }

       
        //public virtual string SecurityStamp { get; set; }

        
        //public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        
        //public virtual string PhoneNumber { get; set; }

        
        //public virtual bool PhoneNumberConfirmed { get; set; }

        
        //public virtual bool TwoFactorEnabled { get; set; }

       
        //public virtual DateTimeOffset? LockoutEnd { get; set; }

        
        //public virtual bool LockoutEnabled { get; set; }

        //public virtual int AccessFailedCount { get; set; }

    }
}
