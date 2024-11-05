using MediatR;

namespace CleanArchitecture.Application.UserCases.CreateUser
{
    public sealed record CreateUserRequest(string Email, String Name) : IRequest<CreateUserResponse>
    {}
}
