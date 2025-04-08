using FluentValidation;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Application.SaleItems.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

/// <summary>
/// Validator for the <see cref="CreateSaleCommand"/>.
/// </summary>
public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
{
    public CreateSaleCommandValidator()
    {
        RuleFor(s => s.CustomerId)
            .NotEmpty()
            .WithMessage("O identificador do cliente é obrigatório.");

        RuleFor(s => s.CustomerName)
            .NotEmpty()
            .WithMessage("O nome do cliente é obrigatório.");

        RuleFor(s => s.BranchId)
            .NotEmpty()
            .WithMessage("O identificador da loja (filial) é obrigatório.");

        RuleFor(s => s.BranchName)
            .NotEmpty()
            .WithMessage("O nome da loja (filial) é obrigatório.");

        RuleFor(s => s.Items)
            .NotNull()
            .WithMessage("A lista de itens da venda não pode ser nula.")
            .Must(items => items.Any())
            .WithMessage("A venda deve conter pelo menos um item.");
    }
}
