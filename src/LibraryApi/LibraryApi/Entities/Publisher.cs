namespace LibraryApi.Entities
{
    public class Publisher
    {
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<Book> Books { get; set; } = new();
    }
}