namespace Project_libary.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AutherName { get; set; }
        public int NumberoOfPages { get; set; }
        public int Availability { get; set; }
        public DateTime PublishYear { get; set; }
        
        public int CatogoryId { get; set; }
        public int NumberOfTimesBorrow { get; set; }

        public Book(int id, string name, string autherName, int numberoOfPages, int availability, DateTime publishYear, int catogoryId, int numberOfTimesBorrow)
        {
            Id = id;
            Name = name;
            AutherName = autherName;
            NumberoOfPages = numberoOfPages;
            Availability = availability;
            PublishYear = publishYear;
             CatogoryId = catogoryId;
            NumberOfTimesBorrow = numberOfTimesBorrow;
        }

        public Book()
        {
        }
    }
}
