using AutoMapper;
using CleanArchitecture.Domain.Entites;

namespace CleanArchitecture.Application.UserCases.GetAllUser
{
    public sealed class GetAllUserMapper : Profile
    {
        public GetAllUserMapper()
        {
            CreateMap<User, GetAllUserResponse>();
        }
    }
}
