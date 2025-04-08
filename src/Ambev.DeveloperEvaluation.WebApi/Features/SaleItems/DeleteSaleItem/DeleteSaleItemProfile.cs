using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItems.DeleteSaleItem
{
    public class DeleteSaleItemProfile: Profile
    {
        public DeleteSaleItemProfile()
        {
            CreateMap<Guid, Application.SaleItems.DeleteSaleItem.DeleteSaleItemCommand>()
                .ConstructUsing(id => new Application.SaleItems.DeleteSaleItem.DeleteSaleItemCommand(id));
        }

    }
}
