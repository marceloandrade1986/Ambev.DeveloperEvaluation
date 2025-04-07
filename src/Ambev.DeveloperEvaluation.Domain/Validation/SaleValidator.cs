using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleValidator : AbstractValidator<Sale>
{
    public SaleValidator()
    {
        RuleFor(s => s.CustomerId)
            .NotEmpty().WithMessage("CustomerId is required.");

        RuleFor(s => s.BranchId)
            .NotEmpty().WithMessage("BranchId is required.");

        RuleFor(s => s.SaleDate)
            .LessThanOrEqualTo(DateTime.UtcNow)
            .WithMessage("Sale date cannot be in the future.");

        RuleForEach(s => s.SaleItems) // <- corrigido aqui
           .SetValidator(new SaleItemValidator());
    }
}
