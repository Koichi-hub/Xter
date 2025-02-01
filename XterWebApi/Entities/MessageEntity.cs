namespace XterWebApi.Entities
{
    public class MessageEntity
    {
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }

        public UserEntity Author { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTimeOffset CreateDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

        public Guid ChatId { get; set; }

        public ChatEntity Chat { get; set; } = null!;
    }
}
