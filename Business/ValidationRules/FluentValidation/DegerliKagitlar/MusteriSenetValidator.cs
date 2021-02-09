using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MusteriSenetValidator : SenetValidator<MusteriSenet>
    {
        public MusteriSenetValidator() : base()
        {
            RuleFor(p => p.CariIdCiroEden).NotNull();
            RuleFor(p => p.AsilBorclu).NotNull();
            RuleFor(p => p.AlisTarihi).NotNull();
        }
    }
}