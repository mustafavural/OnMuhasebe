using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FaturaValidator : EvrakValidator<Fatura>
    {
        public FaturaValidator() : base()
        {
            RuleFor(p => p.FaturaNo).NotEmpty();
        }
    }
}