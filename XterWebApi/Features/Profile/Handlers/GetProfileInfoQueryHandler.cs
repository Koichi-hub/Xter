using FluentResults;
using Mapster;
using MediatR;
using XterWebApi.Common.Errors;
using XterWebApi.Entities;
using XterWebApi.Features.Profile.Models;
using XterWebApi.Features.Profile.Queries;
using XterWebApi.Features.Profile.Repositories;

namespace XterWebApi.Features.Profile.Handlers
{
    public class GetProfileInfoQueryHandler(UserRepository userRepository) : IRequestHandler<GetProfileInfoQuery, Result<ProfileModel>>
    {
        public async Task<Result<ProfileModel>> Handle(GetProfileInfoQuery request, CancellationToken cancellationToken)
        {
            UserEntity? user = await userRepository.GetUserById(request.ProfileId);
            if (user == null)
            {
                return new NotFoundError("Profile not found");
            }
            return Result.Ok(user.Adapt<ProfileModel>());
        }
    }
}
