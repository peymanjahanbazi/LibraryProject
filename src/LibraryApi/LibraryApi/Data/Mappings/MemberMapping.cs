using LibraryApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApi.Data.Mappings
{
    public class MemberMapping : IEntityTypeConfiguration<Member>

    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
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