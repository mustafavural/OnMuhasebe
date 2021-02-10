using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class KasaHareketValidator : AbstractValidator<KasaHareket>
    {
        public KasaHareketValidator()
        {
            RuleFor(p => p.KasaId).NotNull();
            RuleFor(p => p.PersonelHarId).NotNull();
            RuleFor(p => p.CariHarId).NotNull();
            RuleFor(p => p.BelgeNo).NotNull();
            RuleFor(p => p.Tarih).NotNull();
        }
    }
}
