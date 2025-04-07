using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces
{
    public interface ICustomer
    {
        string Name { get; }
        string Email { get; }
        string Phone { get; }
        DateTime CreatedAt { get; }
        ValidationResultDetail Validate();
    }
}
