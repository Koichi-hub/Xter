using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XterWebApi.Entities;

namespace XterWebApi.DB.EF.EntitiesConfigurations
{
    public class CommentEntityConfiguration : IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Post)
                .WithMany(y => y.Comments)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
