using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDomain.Models
{
	public class Autenticacao
    {
		public int Id { get; set; }
        [ForeignKey("Usuario")]
        public int Usuario_Id { get; set; }
        public Usuario usuario { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string TokenJwt { get; set; }
        public string RefreshTokenJwt { get; set; }
    }
}