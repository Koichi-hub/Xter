using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XterWebApi.Entities;

namespace XterWebApi.DB.EF.EntitiesConfigurations
{
    public class FeedEntityConfiguration : IEntityTypeConfiguration<FeedEntity>
    {
        public void Configure(EntityTypeBuilder<FeedEntity> builder)
        {
            builder.HasKey(x => x.OwnerId);

            builder
                .HasOne(x => x.Owner)
                .WithOne(y => y.Feed)
                .HasForeignKey<FeedEntity>(x => x.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(x => x.Posts)
                .WithMany(y => y.Feeds);
        }
    }
}
