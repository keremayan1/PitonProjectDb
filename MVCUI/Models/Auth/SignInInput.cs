using System.ComponentModel.DataAnnotations;

namespace MVCUI.Models.Auth
{
    public class SignInInput
    {
    
        [Display(Name = "Email Adresi")]
        public string Email { get; set; }
      
        [Display(Name = "Şifreniz")]
        public string Password { get; set; }
       
        [Display(Name = "Beni Hatırla")]
        public bool IsRemember { get; set; }

       

    }
}
