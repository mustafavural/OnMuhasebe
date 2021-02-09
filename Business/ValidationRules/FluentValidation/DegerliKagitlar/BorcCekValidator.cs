using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BorcCekValidator : CekValidator<BorcCek>
    {
        public BorcCekValidator() : base()
        {
            RuleFor(p => p.CariIdVerilen).NotNull();
            RuleFor(p => p.CikisTarihi).NotNull();
            RuleFor(p => p.HesapId).NotNull();
        }
    }
}