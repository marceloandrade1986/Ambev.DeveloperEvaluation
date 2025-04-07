using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Interfaces;
using Ambev.DeveloperEvaluation.Domain.Validation;

public class Sale : BaseEntity, ISale
{
    public Guid SaleId { get; private set; } = Guid.NewGuid();
    public int SaleNumber { get; private set; }
    public DateTime SaleDate { get; private set; }
    public Guid CustomerId { get; private set; }
    public Guid BranchId { get; private set; }
    public decimal TotalAmount { get; private set; }
    public bool IsCancelled { get; private set; }
    public DateTime CreatedAt { get; private set; }

    // Propriedades de navegação — ESSENCIAIS para o EF gerar as FKs
    public Customer? Customer { get; private set; }
    public Branch? Branch { get; private set; }

    public List<SaleItem> SaleItems { get; private set; } = new();


    public Sale(Guid customerId, Guid branchId)
    {
        CustomerId = customerId;
        BranchId = branchId;
        SaleDate = DateTime.UtcNow;
        CreatedAt = DateTime.UtcNow;
        IsCancelled = false;
    }

    public void Cancel()
    {
        IsCancelled = true;
    }

    public void AddSaleItem(SaleItem item)
    {
        SaleItems.Add(item);
        TotalAmount += item.Total;
    }

    public ValidationResultDetail Validate()
    {
        var validator = new SaleValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(e => (ValidationErrorDetail)e)
        };
    }
}
