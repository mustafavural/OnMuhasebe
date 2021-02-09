using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SirketCariValidator : AbstractValidator<SirketCari>
    {
        public SirketCariValidator()
        {
            RuleFor(p => p.Kod).NotEmpty();
            RuleFor(p => p.Unvan).NotEmpty();
            RuleFor(p => p.Unvan).Length(3, 150);
            RuleFor(p => p.VergiDairesi).NotEmpty();
            RuleFor(p => p.VergiNo).NotEmpty();
            RuleFor(p => p.VergiNo).Length(10);
        }
    }
}