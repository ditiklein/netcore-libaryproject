namespace Project_libary.Entities
{
    public class Details
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int BorrowId { get; set; }

        public Details(int id, int bookId, int borrowId)
        {
            Id = id;
            BookId = bookId;
            BorrowId = borrowId;
        }

        public Details()
        {

        }
    }
}
