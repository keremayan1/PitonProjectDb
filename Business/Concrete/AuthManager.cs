using Business.Abstract;
using Core.Entities.EntityFramework.Concrete;
using Core.Utilities.Results;

using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;


        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public  Response<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMailAndPassword(userForLoginDto.Email,userForLoginDto.Password);
            if (userToCheck == null)
            {
                throw new Exception("Hatalı E-Mail ve Şifre");
            }
            return Response<User>.Success(userToCheck,200);
        }

        public async Task<Response<User>> Register(UserForRegisterDto userForRegisterDto)
        {
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Password = userForRegisterDto.Password,
                Status = true
            };
            await _userService.Add(user);

            return Response<User>.Success(200);
        }

       

        public bool UserExits(string email,string password)
        {
            if (_userService.GetByMailAndPassword(email,password) != null)
            {
          
                throw new Exception("Boyle bir kullanici sistemde vardir");
            }
            return true;
        }
    }
}
