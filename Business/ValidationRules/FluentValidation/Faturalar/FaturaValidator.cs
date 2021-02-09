using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FaturaValidator : AbstractValidator<Fatura>
    {
        public FaturaValidator()
        {
            RuleFor(p => p.CariHarId).NotEmpty();
            RuleFor(p => p.PersonelHarId).NotEmpty();
            RuleFor(p => p.Tarih).NotEmpty();
            RuleFor(p => p.FaturaNo).NotEmpty();
            RuleFor(p => p.KayitTarihi).NotEmpty();
        }
    }
}