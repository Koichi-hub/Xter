using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XterWebApi.Entities;

namespace XterWebApi.DB.EF.EntitiesConfigurations
{
    public class PostEntityConfiguration : IEntityTypeConfiguration<PostEntity>
    {
        public void Configure(EntityTypeBuilder<PostEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Author)
                .WithMany(y => y.Posts)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
