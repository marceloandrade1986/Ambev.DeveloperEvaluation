using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Interfaces;

public class SaleItem : BaseEntity, ISaleItem
{
    public Guid SaleItemId { get; private set; } = Guid.NewGuid();
    public Guid SaleId { get; private set; }
    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }
    public decimal Discount { get; private set; }
    public decimal Total { get; private set; }
    public bool IsCancelled { get; private set; }

    public SaleItem(Guid saleId, Guid productId, int quantity, decimal unitPrice, decimal discount)
    {
        SaleId = saleId;
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
        Discount = discount;
        Total = CalculateTotal();
        IsCancelled = false;
    }

    private decimal CalculateTotal()
    {
        var subtotal = UnitPrice * Quantity;
        var discountAmount = subtotal * (Discount / 100m);
        return subtotal - discountAmount;
    }

    public void Cancel()
    {
        IsCancelled = true;
    }

    public ValidationResultDetail Validate()
    {
        var errors = new List<ValidationErrorDetail>();

        if (Quantity <= 0 || Quantity > 20)
            errors.Add(new ValidationErrorDetail
            {
                Error = "Quantity",
                Detail = "Quantity must be between 1 and 20"
            });

        if (!(new[] { 0m, 10m, 20m }.Contains(Discount)))
            errors.Add(new ValidationErrorDetail
            {
                Error = "Discount",
                Detail = "Discount must be 0, 10 or 20"
            });

        return new ValidationResultDetail
        {
            IsValid = !errors.Any(),
            Errors = errors
        };
    }

}
