using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Cariler
{
    public class SahisCariValidator : AbstractValidator<SahisCari>
    {
        public SahisCariValidator()
        {
            RuleFor(p => p.TCNo).NotEmpty();
            RuleFor(p => p.TCNo).Length(11);
            RuleFor(p => p.CariId).NotEmpty().When(w => w.Id > 0);
        }
    }
}