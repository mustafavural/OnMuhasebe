using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Cariler
{
    public class CariValidator : AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.Kod).NotEmpty();
            RuleFor(p => p.Unvan).NotEmpty();
            RuleFor(p => p.Unvan).Length(3, 150);
            RuleFor(p => p.VergiDairesi).NotEmpty();
        }
    }
}