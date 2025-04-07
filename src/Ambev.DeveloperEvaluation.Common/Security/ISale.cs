using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces
{
    public interface ISale
    {
        Guid SaleId { get; }
        int SaleNumber { get; }
        DateTime SaleDate { get; }
        Guid CustomerId { get; }
        Guid BranchId { get; }
        decimal TotalAmount { get; }
        bool IsCancelled { get; }
        DateTime CreatedAt { get; }

        ValidationResultDetail Validate();
    }
}
