using Entities.Concrete;
using FluentValidation;
using System;

namespace Business.ValidationRules.FluentValidation.Cariler
{
    public class CariHareketValidator : AbstractValidator<CariHareket>
    {
        public CariHareketValidator()
        {
            RuleFor(p => p.Aciklama).NotEmpty();
            RuleFor(p => p.Tarih).NotEmpty();
            RuleFor(p => p.Tarih).LessThanOrEqualTo(DateTime.Today);
        }
    }
}