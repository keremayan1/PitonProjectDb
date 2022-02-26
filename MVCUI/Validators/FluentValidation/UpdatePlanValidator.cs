using FluentValidation;
using MVCUI.Models.Plans;

namespace MVCUI.Validators.FluentValidation
{
    public class UpdatePlanValidator:AbstractValidator<UpdatePlanInput>
    {
        public UpdatePlanValidator()
        {
            RuleFor(x => x.Day).NotEmpty().WithMessage("Plan Süre Boş Olamaz!");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Plan Mesajı Boş Olamaz");
        }
    }
}
