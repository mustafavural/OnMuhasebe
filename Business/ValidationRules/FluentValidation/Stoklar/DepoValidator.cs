using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DepoValidator : AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.AdresId).NotEmpty();
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Ad).Length(2, 50);
        }
    }
}