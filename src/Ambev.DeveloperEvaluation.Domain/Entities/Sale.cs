using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale : BaseEntity, ISale
{
    public int SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Identificador do usuário que realizou a venda (antigo CustomerId).
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Lista de produtos vendidos, com quantidade, valor e desconto.
    /// </summary>
    public List<SaleItem> Products { get; set; } = new();

    public decimal TotalAmount { get; set; }
    public bool IsCancelled { get; set; }
    public DateTime CreatedAt { get; set; }

    // Interface mapping
    string ISale.Id => Id.ToString();
    int ISale.SaleNumber => SaleNumber;
    DateTime ISale.SaleDate => SaleDate;
    string ISale.CustomerId => UserId.ToString(); // Pode-se renomear ISale para ICart ou IOrder futuramente
    string ISale.BranchId => string.Empty; // Remover se não estiver usando filiais
    decimal ISale.TotalAmount => TotalAmount;
    bool ISale.IsCancelled => IsCancelled;

    public Sale()
    {
        SaleDate = DateTime.UtcNow;
        CreatedAt = DateTime.UtcNow;
        TotalAmount = 0;
        IsCancelled = false;
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

    public void Cancel()
    {
        IsCancelled = true;
    }
}
