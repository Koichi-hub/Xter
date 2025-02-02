using Microsoft.EntityFrameworkCore;
using XterWebApi.DB.EF;
using XterWebApi.Entities;

namespace XterWebApi.Features.Profile.Repositories
{
    public class UserRepository(DatabaseContext databaseContext)
    {
        public async Task<UserEntity?> GetUserByUserName(string userName)
        {
            return await databaseContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }
    }
}
