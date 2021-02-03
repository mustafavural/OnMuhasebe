using Entities.Concrete;
using FluentValidation;

namespace Business
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