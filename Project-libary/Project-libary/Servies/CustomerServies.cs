using Project_libary.Entities;

namespace Project_libary.Servies
{
    public class CustomerServies
    {

        public  List<Customer> customerlist { get; set; }
        public CustomerServies()
        {
            customerlist = new List<Customer>() {new Customer(1,"ditiklein",new DateTime(),"diiti3809@gmail.com","0534163809","327770038","bnebraq",new DateTime(),5),
            new Customer(2,"laliklein",new DateTime(),"diiti3809@gmail.com","0534163809","327770038","bnebraq",new DateTime(),4) };
        }
        public List<Customer> GetLists()
        {

            return customerlist;
        }
        public Customer getID(int id)
        {
            if (customerlist == null) { return null; }
            return customerlist.Find(c => c.Id == id);
        }
        public bool AddBooks(Customer customer)
        {
            customerlist.Add(customer);
            return true;
        }
        public bool Remove(int id)
        {
            int index = customerlist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                customerlist.Remove(customerlist.Find(x => x.Id == id));
                return true;
            }
            return false;
        }
        public bool UpDate(int id, Customer customer)
        {
            int index = customerlist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                customerlist.Insert(index, customer);
                return true;
            }
            return false;
        }
    }
}
