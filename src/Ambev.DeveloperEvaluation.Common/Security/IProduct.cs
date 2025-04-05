namespace Ambev.DeveloperEvaluation.Common.Security;
public interface IProduct
{
    string Id { get; }
    string Name { get; }
    string Description { get; }
    decimal UnitPrice { get; }
}
