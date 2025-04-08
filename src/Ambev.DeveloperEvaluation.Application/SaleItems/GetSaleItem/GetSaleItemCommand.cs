using Ambev.DeveloperEvaluation.Application.Sales.GetSaleItem;
using MediatR;


/// <summary>
/// Command for retrieving a sale by its ID
/// </summary>
namespace Ambev.DeveloperEvaluation.Application.SaleItems.GetSaleItem;
public record GetSaleItemCommand : IRequest<GetSaleItemResult>
{
    /// <summary>
    /// The unique identifier of the sale to retrieve
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of GetSaleCommand
    /// </summary>
    /// <param name="id">The ID of the sale to retrieve</param>
    public GetSaleItemCommand(Guid id)
    {
        Id = id;
    }
}
