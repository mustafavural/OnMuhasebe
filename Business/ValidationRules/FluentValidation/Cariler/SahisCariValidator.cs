using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Cariler
{
    public class SahisCariValidator : AbstractValidator<SahisCari>
    {
        public SahisCariValidator()
        {
            RuleFor(p => p.Kod).NotEmpty();
            RuleFor(p => p.Unvan).NotEmpty();
            RuleFor(p => p.Unvan).Length(3, 150);
            RuleFor(p => p.VergiDairesi).NotEmpty();
            RuleFor(p => p.TCNo).NotEmpty();
            RuleFor(p => p.TCNo).Length(11);
        }
    }
}