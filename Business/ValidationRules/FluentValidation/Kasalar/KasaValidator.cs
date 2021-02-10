using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class KasaValidator : AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.Ad).NotNull();
            RuleFor(p => p.Aciklama).NotNull();
        }
    }
}
