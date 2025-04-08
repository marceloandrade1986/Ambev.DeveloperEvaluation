using Ambev.DeveloperEvaluation.WebApi.Features.SaleItems.CreateSaleItem;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    /// <summary>
    /// Represents the response after creating a new sale in the system.
    /// </summary>
    public class CreateSaleResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale.
        /// </summary>
        public Guid SaleId { get; set; }

        /// <summary>
        /// Gets or sets the unique sale number.
        /// </summary>
        public string SaleNumber { get; set; } = string.Empty;

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
        public List<CreateSaleItemResponse> Items { get; set; } = new();

        /// <summary>
        /// Gets or sets the total value of the sale.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the sale record.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
