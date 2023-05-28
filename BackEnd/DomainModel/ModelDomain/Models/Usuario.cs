using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ModelDomain.Enum;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomain.Models
{
	public class Usuario : IdentityUser<int>
    {
        public string imageperfil { get; set; } 
        public Endereco endereco { get; set; }//Relação com a Classe e tabela Endereco
        public TipoUsuario tipoUsuario { get; set; }//Relação com a Enum TipoUsuario que contem a tipo de usuário autenticado
        public StatusUsuario statusUsuario { get; set; }//Relação com a Enum StatusUsuario que denomina o aceeso do usuario
    }
}
