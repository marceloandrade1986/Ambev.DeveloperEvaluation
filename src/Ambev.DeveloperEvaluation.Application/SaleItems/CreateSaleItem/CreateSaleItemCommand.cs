using Ambev.DeveloperEvaluation.Application.SaleItems.Validation;
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.CreateSaleItem;

/// <summary>
/// Command for creating a new sale item.
/// </summary>
/// <remarks>
/// This command captures the necessary data for adding an item to a sale, 
/// including product ID, quantity, unit price, discount, and total amount.
/// 
/// The data provided in this command is validated using the 
/// <see cref="CreateSaleItemCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class CreateSaleItemCommand : IRequest<CreateSaleItemResult>
{
    /// <summary>
    /// Gets or sets the product ID associated with the sale item.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product being sold.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit price of the product.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the total discount applied to the item.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Gets or sets the total amount for this sale item after applying the discount.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Validates the command using <see cref="CreateSaleItemCommandValidator"/>.
    /// </summary>
    /// <returns>A validation result indicating whether the command is valid.</returns>
    public ValidationResultDetail Validate()
    {
        var validator = new CreateSaleItemCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}
