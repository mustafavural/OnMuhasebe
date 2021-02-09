using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StokGrupKodValidator : AbstractValidator<StokGrupKod>
    {
        public StokGrupKodValidator()
        {
            RuleFor(p => p.Ad).NotEmpty();
            RuleFor(p => p.Ad).Length(2, 30);
            RuleFor(p => p.Tur).NotEmpty();
        }
    }
}