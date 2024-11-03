using Project_libary.Entities;

namespace Project_libary.Servies
{
    public class Detailsservies
    {

        public  List<Details> detailslist { get; set; }
        public Detailsservies()
        {
            detailslist = new List<Details>() {new Details(1,2,1),
           new Details(2,2,1)};
        }
        public List<Details> GetLists()
        {

            return detailslist;
        }
        public Details getID(int id)
        {
            if (detailslist == null) { return null; }
            return detailslist.Find(c => c.Id == id);
        }
        public bool AddBooks(Details details)
        {
            detailslist.Add(details);
            return true;
        }
        public bool Remove(int id)
        {
            int index = detailslist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                detailslist.Remove(detailslist.Find(x => x.Id == id));
                return true;
            }
            return false;
        }
        public bool UpDate(int id, Details details)
        {
            int index = detailslist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                detailslist.Insert(index, details);
                return true;
            }
            return false;
        }
    }
}
