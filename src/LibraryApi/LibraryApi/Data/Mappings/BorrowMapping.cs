using LibraryApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApi.Data.Mappings
{
    public class BorrowMapping : IEntityTypeConfiguration<Borrow>

    {
        public void Configure(EntityTypeBuilder<Borrow> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.MemberId, x.BookId });

            builder.Property(x => x.BorrowDate)
               .IsRequired();

            builder.Property(x => x.ScheduledReturnDate)
               .IsRequired();

            builder.HasOne(x => x.Book)
                .WithMany(x => x.Borrows)
                .HasForeignKey(x => x.BookId);

            builder.HasOne(x => x.Member)
                .WithMany(x => x.Borrows)
                .HasForeignKey(x => x.MemberId);
        }
    }
}