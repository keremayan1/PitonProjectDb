using FluentValidation;
using MVCUI.Models.Auth;

namespace MVCUI.Validators.FluentValidation
{
    public class SignUpValidator:AbstractValidator<SignUpInput>
    {
        public SignUpValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ad Boş Olamaz!");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("Ad En Az 2 Karakter Olmalıdır");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad Boş Olamaz!");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("Soyad En Az 2 Karakter Olmalıdır");
            RuleFor(x => x.Email).MaximumLength(64).WithMessage("E-Posta En Fazla 64 Karakter Olmalıdır!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-Posta Boş Olamaz!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Olamaz!");
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Şifre En Az 5 Karakterli Olmalıdır");



        }
    }
}
