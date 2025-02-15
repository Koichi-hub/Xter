﻿using FluentResults;
using MediatR;
using XterWebApi.Features.Profile.Models;

namespace XterWebApi.Features.Profile.Queries
{
    public class GetProfileInfoQuery : IRequest<Result<ProfileModel>>
    {
        public string UserName { get; set; } = null!;
    }
}
