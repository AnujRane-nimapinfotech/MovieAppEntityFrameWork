using System.Data.Entity.ModelConfiguration;

namespace MovieApp.EntityTypeConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(255);
        }
    }
}
