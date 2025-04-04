using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUser;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<GetUserResult, GetUserResponse>();
            CreateMap<Guid, GetUserCommand>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src));
        }
    }
}
