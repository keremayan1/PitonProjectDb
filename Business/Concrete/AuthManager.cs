using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
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


        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IUserOperationClaimService userOperationClaimService)
        {
            _userService = userService;
        }
       
        public User Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email,userForLoginDto.Password);
            if (userToCheck == null)
            {
                throw new Exception("Hatalı E-Mail ve Şifre");
            }
            return userToCheck;
        }

        public async Task<User> Register(UserForRegisterDto userForRegisterDto)
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

            return user;
        }

       

        public bool UserExits(string email,string password)
        {
            if (_userService.GetByMail(email,password) != null)
            {
          
                throw new Exception("Boyle bir kullanici sistemde vardir");
            }
            return true;
        }
    }
}
