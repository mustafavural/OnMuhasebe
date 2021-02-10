using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class EvrakValidator<TEntity> : AbstractValidator<TEntity>
        where TEntity : Evrak, new()
    {
        public EvrakValidator()
        {
            RuleFor(p => p.CariHarId).NotEmpty();
            RuleFor(p => p.PersonelHarId).NotEmpty();
            RuleFor(p => p.Tarih).NotEmpty();
            RuleFor(p => p.KayitTarihi).NotEmpty();
        }
    }
}