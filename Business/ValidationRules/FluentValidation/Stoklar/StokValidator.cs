using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.Kod).NotEmpty();
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Ad).Length(2, 50);
            RuleFor(p => p.KDV).NotEmpty();
            RuleFor(p => p.Birim).NotEmpty();
            RuleFor(p => p.Birim2Oran).GreaterThan(0.0m).When(w => w.Birim2 != "");
            RuleFor(p => p.Birim3Oran).GreaterThan(0.0m).When(w => w.Birim3 != "");
            RuleFor(p => p.Birim2Oran).NotEqual(p => p.Birim3Oran).When(p => p.Birim2Oran > 0.0m);
        }
    }
}