using Project_libary.Entities;

namespace Project_libary.Servies
{
    public class Borrowservies
    {

        public  List<Borrow> borrowlist { get; set; }
        public Borrowservies()
        {
            borrowlist = new List<Borrow>() {new Borrow(1,2, new DateTime(), new DateTime(), new DateTime(),true),
            new Borrow(1,2,new DateTime(), new DateTime(), new DateTime(),true)};
        }
        public List<Borrow> GetLists()
        {

            return borrowlist;
        }
        public Borrow getID(int id)
        {
            if (borrowlist == null) { return null; }
            return borrowlist.Find(c => c.Id == id);
        }
        public bool AddBorrow(Borrow borrow)
        {
            borrowlist.Add(borrow);
            return true;
        }
        public bool Remove(int id)
        {
            int index = borrowlist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                borrowlist.Remove(borrowlist.Find(x => x.Id == id));
                return true;
            }
            return false;
        }
        public bool UpDate(int id, Borrow borrow)
        {
            int index = borrowlist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                borrowlist.Insert(index, borrow);
                return true;
            }
            return false;
        }
    }
}
