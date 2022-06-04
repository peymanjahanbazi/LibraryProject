using LibraryApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApi.Data.Mappings
{
    public class PublisherMapping : IEntityTypeConfiguration<Publisher>

    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(
                new Publisher { Id = 1, Name = "Bahar" }
            );
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(150);

            builder.Property(x => x.Description)
               .HasMaxLength(250);
        }
    }
}