using Core.Utilities.Results;


using MVCUI.Models.Auth;
using MVCUI.Services.Abstract;

namespace MVCUI.Services.Concrete
{
    public class IdentityService : IIdentityService
    {
        private readonly HttpClient _httpClient;
      

        public IdentityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
           
        }

        public async Task<SignInInput> GetById(int userId)
        {
            var result = await _httpClient.GetAsync($"http://localhost:5068/api/Auth/getbyid/{userId}");
            if (result==null)
            {
                return null;
            }
            var response =await result.Content.ReadFromJsonAsync<Response<SignInInput>>();
            return response.Data;

        }

        public async Task<bool> SignUp(SignUpInput signUpInput)
        {
            var result = await _httpClient.PostAsJsonAsync<SignUpInput>("http://localhost:5068/api/Auth/register", signUpInput);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> SignIn(SignInInput signInInput)
        {
            var result = await _httpClient.PostAsJsonAsync<SignInInput>("http://localhost:5068/api/Auth/login", signInInput);
            return result.IsSuccessStatusCode;
        }
    }
}
