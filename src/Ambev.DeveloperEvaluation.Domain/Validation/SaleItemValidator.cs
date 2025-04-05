using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;


public class SaleItemValidator : AbstractValidator<SaleItem>
{
    public SaleItemValidator()
    {
        RuleFor(i => i.ProductId)
            .NotEmpty();

        RuleFor(i => i.Quantity)
            .InclusiveBetween(1, 20)
            .WithMessage("Quantity must be between 1 and 20.");

        RuleFor(i => i.UnitPrice)
            .GreaterThan(0)
            .WithMessage("Unit price must be greater than zero.");

        RuleFor(i => i.Discount)
            .Must(d => d == 0 || d == 10 || d == 20)
            .WithMessage("Discount must be 0%, 10%, or 20%.");

        RuleFor(i => i.Total)
            .GreaterThanOrEqualTo(0);
    }
}
