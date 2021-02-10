using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SirketCariValidator : CariValidator<SirketCari>
    {
        public SirketCariValidator() : base()
        {
            RuleFor(p => p.VergiNo).NotEmpty();
            RuleFor(p => p.VergiNo).Length(10);
        }
    }
}