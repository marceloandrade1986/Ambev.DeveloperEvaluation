using Ambev.DeveloperEvaluation.Common.Validation;
using System.Security.Principal;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces
{
    public interface ISaleItem 
    {
        Guid SaleItemId { get; }
        Guid SaleId { get; }
        Guid ProductId { get; }
        int Quantity { get; }
        decimal UnitPrice { get; }
        decimal Discount { get; }
        decimal Total { get; }
        bool IsCancelled { get; }

        ValidationResultDetail Validate();
    }
}
