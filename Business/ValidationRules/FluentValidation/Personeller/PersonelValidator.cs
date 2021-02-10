using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PersonelValidator : AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(p => p.Ad).NotNull();
            RuleFor(p => p.Soyad).NotNull();
            RuleFor(p => p.TCNo).NotNull();
            RuleFor(p => p.DogumTarihi).NotNull();
            RuleFor(p => p.Cinsiyet).NotNull();
        }
    }
}