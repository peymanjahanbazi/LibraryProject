using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Data.Mappings
{
    internal static class MappingConfiguration
    {
        public static void AddMappings(this ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AuthorMapping());
            builder.ApplyConfiguration(new BookMapping());
            builder.ApplyConfiguration(new BorrowMapping());
            builder.ApplyConfiguration(new MemberMapping());
            builder.ApplyConfiguration(new PublisherMapping());
        }
    }
}