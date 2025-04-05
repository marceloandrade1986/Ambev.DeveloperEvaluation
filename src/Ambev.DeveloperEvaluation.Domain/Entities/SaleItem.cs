using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleItem : BaseEntity, ISaleItem
{
    public Guid SaleId { get; set; }
    public Guid ProductId { get; set; }

    /// <summary>
    /// Quantidade do produto no carrinho.
    /// </summary>
    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public decimal Total { get; set; }
    public bool IsCancelled { get; set; }

    string ISaleItem.Id => Id.ToString();
    string ISaleItem.SaleId => SaleId.ToString();
    string ISaleItem.ProductId => ProductId.ToString();
    int ISaleItem.Quantity => Quantity;
    decimal ISaleItem.UnitPrice => UnitPrice;
    decimal ISaleItem.Discount => Discount;
    decimal ISaleItem.Total => Total;
    bool ISaleItem.IsCancelled => IsCancelled;

    public ValidationResultDetail Validate()
    {
        var validator = new SaleItemValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(e => (ValidationErrorDetail)e)
        };
    }

    public void Cancel()
    {
        IsCancelled = true;
    }
}
