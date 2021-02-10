using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CariValidator<TEntity> : AbstractValidator<TEntity>
        where TEntity : Cari, new()
    {
        public CariValidator()
        {
            RuleFor(p => p.Kod).NotEmpty();
            RuleFor(p => p.Unvan).NotEmpty();
            RuleFor(p => p.Unvan).Length(3, 150);
            RuleFor(p => p.VergiDairesi).NotEmpty();
        }
    }
}