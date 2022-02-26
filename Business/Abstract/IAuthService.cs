using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<User> Register(UserForRegisterDto userForRegisterDto);
        User Login(UserForLoginDto userForLoginDto);
        bool UserExits(string email,string password);
     
    }
}
