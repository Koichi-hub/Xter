namespace XterWebApi.Features.Profile.Models
{
    public class ProfileModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public DateTimeOffset CreateDate { get; set; }
    }
}
