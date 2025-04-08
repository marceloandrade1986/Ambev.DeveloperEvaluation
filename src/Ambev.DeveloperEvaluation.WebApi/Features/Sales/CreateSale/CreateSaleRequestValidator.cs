using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales
{
    /// <summary>
    /// Validator for CreateSaleRequest that defines validation rules for sale creation.
    /// </summary>
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
        /// </summary>
        public CreateSaleRequestValidator()
        {
            RuleFor(sale => sale.SaleDate)
                .NotEmpty().WithMessage("A data da venda é obrigatória.")
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("A data da venda não pode ser no futuro.");

            RuleFor(sale => sale.ClientId)
                .NotEmpty().WithMessage("O ID do cliente é obrigatório.");

            RuleFor(sale => sale.StoreId)
                .NotEmpty().WithMessage("O ID da loja é obrigatório.");

            RuleFor(sale => sale.Items)
                .NotEmpty().WithMessage("A venda deve conter pelo menos um item.")
                .Must(items => items.Count > 0).WithMessage("A venda precisa ter pelo menos um item.");

            RuleFor(sale => sale.TotalAmount)
                .GreaterThanOrEqualTo(0).WithMessage("O valor total da venda não pode ser negativo.");
        }
    }
}
