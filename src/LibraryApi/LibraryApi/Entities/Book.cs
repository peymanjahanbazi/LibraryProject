namespace LibraryApi.Entities
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public long AuthorId { get; set; }
        public long PublisherId { get; set; }
        public int PublishYear { get; set; }
        public Author? Author { get; set; }
        public Publisher? Publisher { get; set; }

        public List<Borrow> Borrows { get; set; } = new();
    }
}