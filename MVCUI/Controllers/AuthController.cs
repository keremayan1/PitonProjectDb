using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

using MVCUI.Models.Auth;
using MVCUI.Services.Abstract;
using System.Security.Claims;

namespace MVCUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IIdentityService _identityService;
       

        public AuthController(IIdentityService identityService) 
        {
            _identityService = identityService; 
            
        }

       
        public IActionResult Index()
        {

          
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInInput signInInput)
        {
           
            if (await _identityService.SignIn(signInInput))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,signInInput.Email)
                };
             
               
                return RedirectToAction("Index", "Plans");
            }
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpInput signUpInput)
        {

            await _identityService.SignUp(signUpInput);
            return RedirectToAction("Index", "Plans");
           
        }
    }
}
