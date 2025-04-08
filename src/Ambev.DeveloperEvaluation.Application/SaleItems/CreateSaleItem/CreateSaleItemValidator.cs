using FluentValidation;
using Ambev.DeveloperEvaluation.Application.SaleItems.CreateSaleItem;
using System;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.Validation
{
    /// <summary>
    /// Validator for CreateSaleItemCommand that defines validation rules for sale item creation.
    /// </summary>
    public class CreateSaleItemCommandValidator : AbstractValidator<CreateSaleItemCommand>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleItemCommandValidator with defined validation rules.
        /// </summary>
        public CreateSaleItemCommandValidator()
        {
            RuleFor(item => item.ProductId)
                .NotEmpty().WithMessage("Product ID is required.");

            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than zero.");

            RuleFor(item => item.UnitPrice)
                .GreaterThan(0).WithMessage("Unit price must be greater than zero.");

            RuleFor(item => item.Discount)
                .GreaterThanOrEqualTo(0).WithMessage("Discount cannot be negative.");

            RuleFor(item => item.TotalAmount)
                .GreaterThanOrEqualTo(0).WithMessage("Total amount cannot be negative.")
                .Must((item, totalAmount) => totalAmount == (item.Quantity * item.UnitPrice - item.Discount))
                .WithMessage("Total amount must match quantity * unit price minus discount.");
        }
    }
}
