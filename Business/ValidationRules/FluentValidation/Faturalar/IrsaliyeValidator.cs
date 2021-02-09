using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class IrsaliyeValidator : AbstractValidator<Irsaliye>
    {
        public IrsaliyeValidator()
        {
            RuleFor(p => p.CariHarId).NotEmpty();
            RuleFor(p => p.PersonelHarId).NotEmpty();
            RuleFor(p => p.Tarih).NotEmpty();
            RuleFor(p => p.IrsaliyeNo).NotEmpty();
            RuleFor(p => p.KayitTarihi).NotEmpty();
        }
    }
}