using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Interfaces;

public class Customer : BaseEntity, ICustomer
{
    public Guid CustomerId { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Customer(string name, string email, string phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
        CreatedAt = DateTime.UtcNow;
    }

    public ValidationResultDetail Validate()
    {
        // Adicione seu validador específico se tiver
        return new ValidationResultDetail { IsValid = true };
    }
}
