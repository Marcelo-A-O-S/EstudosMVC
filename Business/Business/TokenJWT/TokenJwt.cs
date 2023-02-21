using Business.TokenJWT.ITokenJWT;
using Business.ViewModel;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Business.TokenJWT
{
    public class TokenJwt : ITokenJwt
    {
        private readonly IConfiguration configuration;

        public TokenJwt(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string CreateToken(UserData usuario)
        {
            var key = configuration.GetSection("KeyJwt").Value;
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuario.userName));
            claims.Add(new Claim(ClaimTypes.Email, usuario.Email));
            claims.Add(new Claim(ClaimTypes.Role, usuario.Role));
            var KeyJwt = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credential = new SigningCredentials(KeyJwt, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                claims: claims,
                signingCredentials: credential,
                expires: DateTime.Now.AddHours(8)
                );
            var tokenJwt = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenJwt;
        }
    }
}
