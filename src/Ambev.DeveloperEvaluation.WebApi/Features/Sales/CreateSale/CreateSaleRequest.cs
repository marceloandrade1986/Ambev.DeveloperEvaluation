using Ambev.DeveloperEvaluation.WebApi.Features.SaleItems.CreateSaleItem;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Represents a request to create a new sale in the system.
/// </summary>
public class CreateSaleRequest
{
    /// <summary>
    /// Gets or sets the date when the sale was made.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the client who made the purchase.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the store where the sale was made.
    /// </summary>
    public Guid StoreId { get; set; }

    /// <summary>
    /// Gets or sets the list of items in the sale.
    /// </summary>
    public List<CreateSaleItemRequest> Items { get; set; } = new();

    /// <summary>
    /// Gets or sets the total value of the sale.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the sale is cancelled.
    /// </summary>
    public bool IsCancelled { get; set; }
}
