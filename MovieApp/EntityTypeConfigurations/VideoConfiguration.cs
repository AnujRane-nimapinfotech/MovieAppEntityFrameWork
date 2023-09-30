using System.Data.Entity.ModelConfiguration;

namespace MovieApp.EntityTypeConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {

            Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(225);

            HasRequired(c => c.Genre)
            .WithMany(c => c.Videos)
            .HasForeignKey(c => c.GenreId);

            HasMany(c => c.Tags)
            .WithMany(c => c.Videos)
            .Map(c =>
            {
                c.ToTable("VideoTags");
                c.MapLeftKey("VideoId");
                c.MapRightKey("TagId");
            });
        }
    }
}
