using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class IrsaliyeValidator : EvrakValidator<Irsaliye>
    {
        public IrsaliyeValidator() : base()
        {
            RuleFor(p => p.IrsaliyeNo).NotEmpty();
        }
    }
}