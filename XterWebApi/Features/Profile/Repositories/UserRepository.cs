using Microsoft.EntityFrameworkCore;
using XterWebApi.DB.EF;
using XterWebApi.Entities;

namespace XterWebApi.Features.Profile.Repositories
{
    public class UserRepository(DatabaseContext databaseContext)
    {
        public async Task<UserEntity?> GetUserById(Guid id)
        {
            return await databaseContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
