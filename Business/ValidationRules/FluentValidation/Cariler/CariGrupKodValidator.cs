using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Cariler
{
    public class CariGrupKodValidator : AbstractValidator<CariGrupKod>
    {
        public CariGrupKodValidator()
        {
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Ad).Length(2, 30);
            RuleFor(p => p.Tur).NotEmpty();
        }
    }
}