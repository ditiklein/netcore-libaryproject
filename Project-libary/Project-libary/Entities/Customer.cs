namespace Project_libary.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Identity { get; set; }
        public string City { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int NumbersOfOrders { get; set; }
        public Customer() { }

        public Customer(int id, string name, DateTime birthDate, string email, string phone, string identity, string city, DateTime registrationDate, int numbersOfOrders)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
            Identity = identity;
            City = city;
            RegistrationDate = registrationDate;
            NumbersOfOrders = numbersOfOrders;
        }
    }
}
