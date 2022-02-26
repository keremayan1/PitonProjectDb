using IdentityModel.Client;
using MVCUI.Models;
using MVCUI.Services.Abstract;

namespace MVCUI.Services.Concrete
{
    public class IdentityService : IIdentityService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityService(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> SignIn(SignInInput signInInput)
        {
            var result = await _httpClient.PostAsJsonAsync<SignInInput>("http://localhost:5068/api/Auth/login", signInInput);
            return result.IsSuccessStatusCode;
        }
    }
}
