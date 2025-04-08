using MediatR;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IProductRepository _productRepository;

    public CreateSaleHandler(ISaleRepository saleRepository, IProductRepository productRepository)
    {
        _saleRepository = saleRepository;
        _productRepository = productRepository;
    }

    public async Task<CreateSaleResult> Handle(CreateSaleCommand request, CancellationToken cancellationToken)
    {
        // Criar a venda com CustomerId e BranchId
        var sale = new Sale(request.CustomerId, request.BranchId);

        foreach (var item in request.Items)
        {
            // Regra de desconto progressivo
            decimal discount = item.Quantity switch
            {
                >= 15 => 20m,
                >= 10 => 10m,
                _ => 0m
            };

            // Calcular total com desconto
            decimal total = item.Quantity * item.UnitPrice * (1 - (discount / 100));

            var saleItem = new SaleItem(
                saleId: sale.SaleId,
                productId: item.ProductId,
                quantity: item.Quantity,
                unitPrice: item.UnitPrice,
                discount: discount,
                total: total
            );

            sale.AddSaleItem(saleItem);
        }


        // Persistir a venda
        await _saleRepository.CreateAsync(sale, cancellationToken);

        // Retornar resultado
        return new CreateSaleResult
        {
            SaleId = sale.SaleId,
            SaleNumber = sale.SaleNumber,
            TotalAmount = sale.TotalAmount
        };
    }
}
