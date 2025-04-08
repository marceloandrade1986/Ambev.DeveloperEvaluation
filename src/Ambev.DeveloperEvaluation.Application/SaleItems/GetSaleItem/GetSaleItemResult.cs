namespace Ambev.DeveloperEvaluation.Application.Sales.GetSaleItem
{
    /// <summary>
    /// Response model for GetSale operation
    /// </summary>
    public class GetSaleItemResult
    {
        /// <summary>
        /// The unique identifier of the sale
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The date when the sale was made
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// The unique identifier of the client who made the purchase
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// The unique identifier of the store where the sale was made
        /// </summary>
        public Guid StoreId { get; set; }

        /// <summary>
        /// The list of items in the sale
        /// </summary>
        public List<GetSaleItemResult> Items { get; set; } = new();

        /// <summary>
        /// The total value of the sale
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Indicates whether the sale is cancelled
        /// </summary>
        public bool IsCancelled { get; set; }
    }
}
