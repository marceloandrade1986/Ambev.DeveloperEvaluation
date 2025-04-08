using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItems.GetSaleItem
{
    public class GetSaleItemProfile : Profile
    {
        public GetSaleItemProfile()
        {
            CreateMap<Guid, Application.SaleItems.GetSaleItem.GetSaleItemCommand>()
                  .ConstructUsing(id => new Application.SaleItems.GetSaleItem.GetSaleItemCommand(id));
        }
    }
}
