namespace LibraryApi.Entities
{
    public class Borrow
    {
        public long Id { get; set; }
        public long MemberId { get; set; }
        public long BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ScheduledReturnDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Member Member { get; set; }
        public Book Book { get; set; }
    }
}