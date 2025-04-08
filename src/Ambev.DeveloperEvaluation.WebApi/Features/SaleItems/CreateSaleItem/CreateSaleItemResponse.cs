﻿namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItems.CreateSaleItem
{
    /// <summary>
    /// Represents the response after creating a new sale item.
    /// </summary>
    public class CreateSaleItemResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale item.
        /// </summary>
        public Guid SaleItemId { get; set; }

        /// <summary>
        /// Gets or sets the product ID associated with the sale item.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product being sold.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the product.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the total discount applied to the item.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets the total amount for this sale item after applying the discount.
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}
