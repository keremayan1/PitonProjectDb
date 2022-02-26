
using Core.Entities.EntityFramework.Concrete;
using Core.Utilities.Results;
using Entities.Concrete.Dto;


namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<Response<User>> Register(UserForRegisterDto userForRegisterDto);
        Response<User> Login(UserForLoginDto userForLoginDto);
        bool UserExits(string email,string password);
    

    }
}
