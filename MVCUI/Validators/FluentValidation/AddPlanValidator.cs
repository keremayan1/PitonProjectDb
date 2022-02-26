using FluentValidation;
using MVCUI.Models.Plans;

namespace MVCUI.Validators.FluentValidation
{
    public class AddPlanValidator:AbstractValidator<AddPlanInput>
    {
        public AddPlanValidator()
        {
            RuleFor(x => x.Time).NotEmpty().WithMessage("Plan Süre Boş Olamaz!");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Plan Mesajı Boş Olamaz");
            
        }
    }
}
