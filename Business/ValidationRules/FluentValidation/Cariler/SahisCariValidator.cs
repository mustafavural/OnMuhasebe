using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SahisCariValidator : CariValidator<SahisCari>
    {
        public SahisCariValidator() : base()
        {
            RuleFor(p => p.TCNo).NotEmpty();
            RuleFor(p => p.TCNo).Length(11);
        }
    }
}