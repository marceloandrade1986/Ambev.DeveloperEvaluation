using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Infrastructure.Persistence.Repositories;

public class InMemorySaleRepository : ISaleRepository
{
    private readonly List<Sale> _sales = new();

    public Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default)
    {
        _sales.Add(sale);
        return Task.FromResult(sale);
    }

    public Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var sale = _sales.FirstOrDefault(s => s.SaleId == id);
        return Task.FromResult(sale);
    }

    public Task<IEnumerable<Sale>> GetByCustomerIdAsync(Guid customerId, CancellationToken cancellationToken = default)
    {
        var result = _sales.Where(s => s.CustomerId == customerId);
        return Task.FromResult(result);
    }

    public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var sale = _sales.FirstOrDefault(s => s.SaleId == id);
        if (sale != null)
        {
            _sales.Remove(sale);
            return Task.FromResult(true);
        }

        return Task.FromResult(false);
    }
}
