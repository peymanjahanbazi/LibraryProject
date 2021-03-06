using LibraryApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApi.Data.Mappings
{
    public class AuthorMapping : IEntityTypeConfiguration<Author>

    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author { Id = 1, Firstname = "Ali Akbar", Lastname = "Dehkhoda" }
                );
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Firstname)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Lastname)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}