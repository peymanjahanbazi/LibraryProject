namespace LibraryApi.Models.Book;

public class AddBookViewModel
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public long AuthorId { get; set; }
    public long PublisherId { get; set; }
    public int PublishYear { get; set; }
}