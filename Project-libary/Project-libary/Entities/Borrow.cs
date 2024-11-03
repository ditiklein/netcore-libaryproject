namespace Project_libary.Entities
{
    public class Borrow
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime BorrowingDate { get; set; }
       
        public DateTime EstimatedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Status { get; set; }

        public Borrow(int id, int customerId, DateTime borrowingDate, DateTime estimatedReturnDate, DateTime returnDate, bool status)
        {
            Id = id;
            CustomerId = customerId;
            BorrowingDate = borrowingDate;
            EstimatedReturnDate = estimatedReturnDate;
            ReturnDate = returnDate;
            Status = status;
        }

        public Borrow()
        {
        }
    }
}
