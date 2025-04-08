using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleItemValidator : AbstractValidator<SaleItem>
{
    public SaleItemValidator()
    {
        RuleFor(i => i.ProductId)
            .NotEmpty().WithMessage("Product ID is required.");

        RuleFor(i => i.Quantity)
            .InclusiveBetween(1, 20).WithMessage("Quantity must be between 1 and 20.");

        RuleFor(i => i.UnitPrice)
            .GreaterThan(0).WithMessage("Unit price must be greater than zero.");

        RuleFor(i => i.Discount)
            .Must(d => d == 0m || d == 10m || d == 20m)
            .WithMessage("Discount must be 0, 10 or 20.");

        RuleFor(i => i.Total)
            .GreaterThan(0).WithMessage("Total must be greater than zero.");
    }
}
