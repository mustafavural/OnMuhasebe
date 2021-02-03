using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Cariler
{
    public class SirketCariValidator : AbstractValidator<SirketCari>
    {
        public SirketCariValidator()
        {
            RuleFor(p => p.VergiNo).NotEmpty();
            RuleFor(p => p.VergiNo).Length(10);
        }
    }
}