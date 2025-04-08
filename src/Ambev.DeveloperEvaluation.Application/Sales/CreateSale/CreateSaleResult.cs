using Ambev.DeveloperEvaluation.Application.SaleItems.CreateSaleItem;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Represents the result of a successful sale creation operation.
/// </summary>
public class CreateSaleResult
{
    /// <summary>
    /// The unique identifier of the created sale.
    /// </summary>
    public Guid SaleId { get; set; }

    /// <summary>
    /// The string representation of the sale number.
    /// </summary>
    public int SaleNumber { get; set; } 

    /// <summary>
    /// The date and time when the sale was made.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// The ID of the customer associated with the sale.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// The ID of the store (branch) where the sale occurred.
    /// </summary>
    public Guid StoreId { get; set; }

    /// <summary>
    /// The list of items included in the sale.
    /// </summary>
    public List<CreateSaleItemResult> Items { get; set; } = new();

    /// <summary>
    /// The total monetary amount of the sale.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Whether the sale has been cancelled.
    /// </summary>
    public bool IsCancelled { get; set; }

    /// <summary>
    /// The creation timestamp of the sale.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
