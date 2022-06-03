namespace LibraryApi.Entities
{
    public class Member
    {
        public long Id { get; set; }
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public List<Borrow> Borrows { get; set; } = new();
    }
}