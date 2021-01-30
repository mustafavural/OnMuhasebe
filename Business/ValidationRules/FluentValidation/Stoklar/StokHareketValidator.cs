using Entities.Concrete;
using FluentValidation;
using System;

namespace Business.ValidationRules.FluentValidation.Stoklar
{
    public class StokHareketValidator : AbstractValidator<StokHareket>
    {
        public StokHareketValidator()
        {
            RuleFor(p => p.Aciklama).NotEmpty();
            RuleFor(p => p.Tarih).NotEmpty();
            RuleFor(p => p.Tarih).LessThanOrEqualTo(DateTime.Today);
        }
    }
}