using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SenetValidator<TEntity> : DegerliKagitValidator<TEntity>
        where TEntity : Senet, new()
    {
        public SenetValidator() : base()
        {
            RuleFor(p => p.Kod).NotNull();
        }
    }
}