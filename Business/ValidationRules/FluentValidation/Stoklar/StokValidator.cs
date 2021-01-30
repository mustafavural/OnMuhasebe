using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Stoklar
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Ad).Length(2, 50);
            RuleFor(p => p.Kod).NotEmpty();
        }
    }
}