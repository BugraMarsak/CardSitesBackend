using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(p => p.Number).NotEmpty();
            RuleFor(p => p.Number).GreaterThan(-1);
        }

    }
}
