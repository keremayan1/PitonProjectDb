using Business.Abstract;
using Entities.Concrete.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (userToLogin==null)
            {
                return BadRequest(userToLogin);
            }
          return Ok(userToLogin);
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExits(userForRegisterDto.Email,userForRegisterDto.Password);
            if (!userExists)
            {
                return BadRequest(userExists);
            }
            var registerResult =await _authService.Register(userForRegisterDto);
          
            if (registerResult.IsSuccessful)
            {
                return Ok(registerResult);
            }
            return BadRequest(registerResult);
        }
       
    }
}
