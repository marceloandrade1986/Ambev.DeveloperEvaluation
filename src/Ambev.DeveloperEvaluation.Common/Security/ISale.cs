namespace Ambev.DeveloperEvaluation.Common.Security 
{
    public interface ISale
    {
        string Id { get; }
        int SaleNumber { get; }
        DateTime SaleDate { get; }
        string CustomerId { get; }
        string BranchId { get; }
        decimal TotalAmount { get; }
        bool IsCancelled { get; }
    }

}
