using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDomain.Models
{
	public class Autenticacao
    {
        //Dados pertinentes para autenticação do usuário, dados para segurança de acesso
		public int Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string TokenJwt { get; set; }
        public string RefreshTokenJwt { get; set; }
        
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario usuario { get; set; }
    }
}