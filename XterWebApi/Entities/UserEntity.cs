namespace XterWebApi.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTimeOffset CreateDate { get; set; }

        public IEnumerable<ChatEntity> Chats { get; set; } = [];

        public IEnumerable<PostEntity> Posts { get; set; } = [];

        public IEnumerable<UserEntity> Followers { get; set; } = [];

        public IEnumerable<UserEntity> Followees { get; set; } = [];

        public Guid FeedId { get; set; }

        public FeedEntity Feed { get; set; } = null!;
    }
}
