using Entities.Concrete;
using FluentValidation;
using System;

namespace Business.ValidationRules.FluentValidation
{
    public class DegerliKagitValidator<TEntity> : AbstractValidator<TEntity>
        where TEntity : DegerliKagit, new()
    {
        public DegerliKagitValidator()
        {
            RuleFor(p => p.Tutar).NotNull();
            RuleFor(p => p.Tutar).GreaterThan(0.0m);
            RuleFor(p => p.Vade).NotNull();
            RuleFor(p => p.Vade).GreaterThan(DateTime.Today);
        }
    }
}