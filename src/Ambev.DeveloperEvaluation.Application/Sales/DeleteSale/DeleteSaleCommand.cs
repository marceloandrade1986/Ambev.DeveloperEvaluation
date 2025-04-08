using Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;
using MediatR;


/// <summary>
/// Command for deleting a sale
/// </summary>
namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;
public record DeleteSaleCommand : IRequest<DeleteSaleResponse>
{
    /// <summary>
    /// The unique identifier of the sale to delete
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of DeleteSaleCommand
    /// </summary>
    /// <param name="id">The ID of the user to delete</param>
    public DeleteSaleCommand(Guid id)
    {
        Id = id;
    }
}
