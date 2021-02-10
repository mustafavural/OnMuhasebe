using Entities.Concrete;
using FluentValidation;
using System;

namespace Business.ValidationRules.FluentValidation
{
    public class PersonelHareketValidator : AbstractValidator<PersonelHareket>
    {
        public PersonelHareketValidator()
        {
            RuleFor(p => p.PersonelId).NotNull();
            RuleFor(p => p.Tur).NotNull();
            RuleFor(p => p.IslemTarihi).NotNull();
            RuleFor(p => p.IslemTarihi).LessThanOrEqualTo(DateTime.Today);
        }
    }
}