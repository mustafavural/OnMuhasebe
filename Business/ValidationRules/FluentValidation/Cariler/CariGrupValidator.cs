using Entities.Concrete;
using FluentValidation;

namespace Business
{
    public class CariGrupValidator : AbstractValidator<CariGrup>
    {
        public CariGrupValidator()
        {
            RuleFor(p => p.CariId).NotEmpty();
            RuleFor(p => p.CariGrupKodId).NotEmpty();
        }
    }
}