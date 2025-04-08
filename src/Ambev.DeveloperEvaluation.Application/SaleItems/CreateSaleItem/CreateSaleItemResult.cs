using System;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.CreateSaleItem
{
    /// <summary>
    /// Response model for CreateSaleItem operation
    /// </summary>
    public class CreateSaleItemResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale item.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the product associated with the sale item.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product in the sale item.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the product in the sale item.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the total discount applied to the sale item.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets the total amount for this sale item after applying the discount.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the date when the sale item was added to the sale.
        /// </summary>
        public DateTime SaleDate { get; set; }
    }
}
