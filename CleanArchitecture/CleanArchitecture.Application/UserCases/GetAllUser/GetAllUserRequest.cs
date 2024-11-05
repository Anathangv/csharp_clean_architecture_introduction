using MediatR;

namespace CleanArchitecture.Application.UserCases.GetAllUser
{
    public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>
    {}
}
