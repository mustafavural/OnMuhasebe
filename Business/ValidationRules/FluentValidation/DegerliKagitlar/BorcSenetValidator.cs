using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BorcSenetValidator : SenetValidator<BorcSenet>
    {
        public BorcSenetValidator() : base()
        {
            RuleFor(p => p.CariIdVerilen).NotNull();
            RuleFor(p => p.CikisTarihi).NotNull();
        }
    }
}