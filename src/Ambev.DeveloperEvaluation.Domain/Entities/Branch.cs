using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;

public class Branch : BaseEntity, IBranch
{
    public Guid BranchId { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; }
    public string Location { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Branch(string name, string location)
    {
        Name = name;
        Location = location;
        CreatedAt = DateTime.UtcNow;
    }

    public ValidationResultDetail Validate()
    {
        return new ValidationResultDetail { IsValid = true };
    }
}
