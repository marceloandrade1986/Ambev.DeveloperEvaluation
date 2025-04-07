using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Interfaces;

public class Product : BaseEntity, IProduct
{
    public Guid ProductId { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public decimal UnitPrice { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public List<SaleItem> SaleItems { get; private set; } = new();

    public Product(string name, decimal unitPrice, string? description = null)
    {
        Name = name;
        UnitPrice = unitPrice;
        Description = description;
        CreatedAt = DateTime.UtcNow;
    }

    public ValidationResultDetail Validate()
    {
        return new ValidationResultDetail { IsValid = true };
    }
}
