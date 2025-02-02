using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace XterWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class FeedController : ControllerBase
    {
    }
}
