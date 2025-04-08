using Ambev.DeveloperEvaluation.Application.SaleItems.GetSaleItem;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSaleItem;

/// <summary>
/// Validator for GetSaleCommand
/// </summary>
public class GetSaleItemValidator : AbstractValidator<GetSaleItemCommand>
{
    /// <summary>
    /// Initializes validation rules for GetSaleCommand
    /// </summary>
    public GetSaleItemValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Sale ID is required");
    }
}
