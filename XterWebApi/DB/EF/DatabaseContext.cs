using Microsoft.EntityFrameworkCore;
using XterWebApi.DB.EF.EntitiesConfigurations;
using XterWebApi.Entities;

namespace XterWebApi.DB.EF
{
    public class DatabaseContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<FeedEntity> Feeds { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserEntityConfiguration().Configure(modelBuilder.Entity<UserEntity>());
            new ChatEntityConfiguration().Configure(modelBuilder.Entity<ChatEntity>());
            new MessageEntityConfiguration().Configure(modelBuilder.Entity<MessageEntity>());
            new FeedEntityConfiguration().Configure(modelBuilder.Entity<FeedEntity>());
            new PostEntityConfiguration().Configure(modelBuilder.Entity<PostEntity>());
            new CommentEntityConfiguration().Configure(modelBuilder.Entity<CommentEntity>());
        }
    }
}
