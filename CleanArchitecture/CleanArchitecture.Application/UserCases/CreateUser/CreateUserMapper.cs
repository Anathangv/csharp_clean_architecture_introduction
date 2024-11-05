using AutoMapper;
using CleanArchitecture.Domain.Entites;

namespace CleanArchitecture.Application.UserCases.CreateUser
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserRequest>();
            CreateMap<CreateUserResponse, User>();
            CreateMap<User, CreateUserResponse>();
        }
    }
}
