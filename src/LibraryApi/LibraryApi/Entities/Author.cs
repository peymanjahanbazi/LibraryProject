namespace LibraryApi.Entities
{
    public class Author
    {
        public long Id { get; set; }
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public List<Book> Books { get; set; } = new();
    }
}