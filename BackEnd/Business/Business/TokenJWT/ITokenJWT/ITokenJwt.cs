using Business.ViewModel;

namespace Business.TokenJWT.ITokenJWT
{
    public interface ITokenJwt
    {
        string CreateToken(UserData usuario);
    }
}
