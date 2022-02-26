using MVCUI.Models;

namespace MVCUI.Services.Abstract
{
    public interface IIdentityService
    {
        Task<bool> SignIn(SignInInput signInInput);
    }
}
