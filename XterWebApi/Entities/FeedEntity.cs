namespace XterWebApi.Entities
{
    public class FeedEntity
    {
        public Guid OwnerId { get; set; }

        public UserEntity Owner { get; set; } = null!;

        public IEnumerable<PostEntity> Posts { get; set; } = [];
    }
}
