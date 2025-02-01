namespace XterWebApi.Entities
{
    public class PostEntity
    {
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }

        public UserEntity Author { get; set; } = null!;

        public string Content { get; set; } = null!;

        public long Likes { get; set; }

        public long Views { get; set; }

        public DateTimeOffset CreateDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

        public IEnumerable<CommentEntity> Comments { get; set; } = [];

        public IEnumerable<FeedEntity> Feeds { get; set; } = [];
    }
}
