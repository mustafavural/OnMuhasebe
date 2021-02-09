using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StokGrupValidator : AbstractValidator<StokGrup>
    {
        public StokGrupValidator()
        {
            RuleFor(p => p.StokGrupKodId).NotEmpty();
            RuleFor(p => p.StokId).NotEmpty();
        }
    }
}