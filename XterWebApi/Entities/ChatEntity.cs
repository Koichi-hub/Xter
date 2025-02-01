namespace XterWebApi.Entities
{
    public class ChatEntity
    {
        public Guid Id { get; set; }

        public IEnumerable<UserEntity> Participants { get; set; } = [];

        public IEnumerable<MessageEntity> Messages { get; set; } = [];
    }
}
