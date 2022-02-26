

using MVCUI.Models.Auth;

namespace MVCUI.Services.Abstract
{
    public interface IIdentityService
    {
        Task<bool> SignUp(SignUpInput signUpInput);
        Task<bool> SignIn(SignInInput signInInput);
        Task<SignInInput> GetById(int id);
    }
}
