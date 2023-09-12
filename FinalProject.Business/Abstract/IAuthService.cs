using FinalProject.Core.Entities.Concrete;
using FinalProject.Core.Utilities.Results.Abstract;
using FinalProject.Core.Utilities.Security.JWT;
using FinalProject.Entities.Dtos;

namespace FinalProject.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}