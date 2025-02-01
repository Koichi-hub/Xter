using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using XterWebApi.Common;
using XterWebApi.Common.Errors;
using XterWebApi.Common.Extensions;
using XterWebApi.Features.Profile.Models;
using XterWebApi.Features.Profile.Queries;

namespace XterWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ApiResult<ProfileModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResult), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProfileInfo([FromRoute] Guid profileId)
        {
            Result<ProfileModel> result = await mediator.Send(new GetProfileInfoQuery
            {
                ProfileId = profileId,
            });
            if (result.HasError<NotFoundError>())
            {
                return NotFound(result.ToApiResult());
            }
            return Ok(result.ToApiResult());
        }
    }
}
