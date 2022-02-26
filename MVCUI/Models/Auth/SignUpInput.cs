using System.ComponentModel.DataAnnotations;

namespace MVCUI.Models.Auth
{
    public class SignUpInput
    {
        [Display(Name ="Adınız")]
        public string FirstName { get; set; }
        [Display(Name ="Soyadınız")]
        public string LastName { get; set; }
        [Display(Name = "Email Adresi")]
        public string Email { get; set; }

        [Display(Name = "Şifreniz")]
        public string Password { get; set; }

    }
}
