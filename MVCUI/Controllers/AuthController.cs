using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MVCUI.Models;
using MVCUI.Services.Abstract;
using System.Security.Claims;

namespace MVCUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IIdentityService _identityService;
        private HttpContext _httpContextAccessor;

        public AuthController(IIdentityService identityService, HttpContext httpContextAccessor) 
        {
            _identityService = identityService; 
            _httpContextAccessor = httpContextAccessor;
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
                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await _httpContextAccessor.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
