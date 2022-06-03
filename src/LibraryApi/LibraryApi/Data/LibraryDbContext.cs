using LibraryApi.Data.Mappings;
using LibraryApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddMappings();
            base.OnModelCreating(builder);
        }
    }
}