using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using XterWebApi.DB.EF;
using XterWebApi.Entities;

namespace XterWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController(DatabaseContext databaseContext) : ControllerBase
    {
        [HttpGet("login/{userName}")]
        public async Task<IActionResult> Login([FromRoute] string userName)
        {
            UserEntity? userEntity = await databaseContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
            if (userEntity == null)
            {
                databaseContext.Users.Add(new UserEntity
                {
                    Id = Guid.NewGuid(),
                    UserName = userName,
                    Feed = new FeedEntity(),
                    FirstName = userName,
                    LastName = userName,
                    Login = userName,
                    Password = userName,
                    CreateDate = DateTime.Now,
                });
                await databaseContext.SaveChangesAsync();
            }

            List<Claim> claims = [
                new(ClaimTypes.Name, userName)
            ];
            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);
            return Ok();
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Ok();
        }
    }
}
