namespace XterWebApi.Entities
{
    public class CommentEntity
    {
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }

        public UserEntity Author { get; set; } = null!;

        public string Content { get; set; } = null!;

        public long Likes { get; set; }

        public DateTimeOffset CreateDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

        public Guid PostId { get; set; }

        public PostEntity Post { get; set; } = null!;
    }
}
