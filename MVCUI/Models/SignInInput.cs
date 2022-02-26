using System.ComponentModel.DataAnnotations;

namespace MVCUI.Models
{
    public class SignInInput
    {
    
        [Display(Name = "Email Adresi")]
        public string Email { get; set; }
      
        [Display(Name = "Şifreniz")]
        public string Password { get; set; }
       
        [Display(Name = "Beni Hatırla")]
        public bool IsRemember { get; set; }

        public bool IsSignIn { get; set; }
    }
}
