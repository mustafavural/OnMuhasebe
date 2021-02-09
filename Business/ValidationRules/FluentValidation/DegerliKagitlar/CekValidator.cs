using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CekValidator<TEntity> : DegerliKagitValidator<TEntity>
        where TEntity : Cek, new()
    {
        public CekValidator() : base()
        {
            RuleFor(p => p.BankaId).NotNull();
            RuleFor(p => p.Kod).NotNull();
        }
    }
}