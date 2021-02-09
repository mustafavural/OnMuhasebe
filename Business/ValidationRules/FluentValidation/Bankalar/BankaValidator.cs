using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BankaValidator : AbstractValidator<Banka>
    {
        public BankaValidator()
        {

        }
    }
}