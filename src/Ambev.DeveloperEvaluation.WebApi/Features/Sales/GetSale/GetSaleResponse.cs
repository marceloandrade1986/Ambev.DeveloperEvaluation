using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale
{
    /// <summary>
    /// Represents the response model for retrieving a sale.
    /// </summary>
    public class GetSaleResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale.
        /// </summary>
        public Guid Id { get; set; }

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
        public List<SaleItem> Items { get; set; } = new();

        /// <summary>
        /// Gets or sets the total value of the sale.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }
    }
}
