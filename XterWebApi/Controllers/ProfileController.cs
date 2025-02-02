using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using XterWebApi.Common;
using XterWebApi.Common.Errors;
using XterWebApi.Common.Extensions;
using XterWebApi.Features.Profile.Models;
using XterWebApi.Features.Profile.Queries;

namespace XterWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ProfileController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult<ProfileModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProfileInfo()
        {
            ClaimsIdentity? claimsIdentity = (ClaimsIdentity?)HttpContext.User.Identity;

            Result<ProfileModel> result = await mediator.Send(new GetProfileInfoQuery
            {
                UserName = claimsIdentity!.Name!,
            });
            if (result.HasError<NotFoundError>())
            {
                return NotFound(result.ToApiResult());
            }
            return Ok(result.ToApiResult());
        }
    }
}
