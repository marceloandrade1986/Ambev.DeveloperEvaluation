using FluentValidation;

/// <summary>
/// Validator for CreateSaleItemRequest that defines validation rules for sale item creation.
/// </summary>
namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItems.CreateSaleItem;
public class CreateSaleItemRequestValidator : AbstractValidator<CreateSaleItemRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleItemRequestValidator with defined validation rules.
        /// </summary>
        public CreateSaleItemRequestValidator()
        {
            RuleFor(item => item.ProductId)
                .NotEmpty().WithMessage("O ID do produto é obrigatório.");

            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("A quantidade deve ser maior que zero.");

            RuleFor(item => item.UnitPrice)
                .GreaterThanOrEqualTo(0).WithMessage("O preço unitário não pode ser negativo.");

            RuleFor(item => item.Discount)
                .GreaterThanOrEqualTo(0).WithMessage("O desconto não pode ser negativo.");

            RuleFor(item => item.TotalAmount)
                .GreaterThanOrEqualTo(0).WithMessage("O valor total do item não pode ser negativo.")
                .Must((item, total) => total == (item.Quantity * item.UnitPrice) - item.Discount)
                .WithMessage("O valor total do item deve ser igual a (Quantidade * Preço Unitário) - Desconto.");
        }
    }


