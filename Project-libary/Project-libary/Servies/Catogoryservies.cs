using Project_libary.Entities;

namespace Project_libary.Servies
{
    public class Catogoryservies
    {
        public  List<Catogory> catogorylist { get; set; }
        public Catogoryservies()
        {
            catogorylist = new List<Catogory>() {new Catogory(1,"tence",true,false,false),
            new Catogory(1,"tence",true,false,false),
            new Catogory(1,"tence",false,true,false),
            new Catogory(1,"tence",false,false,true)};
        }
        public List<Catogory> GetLists()
        {

            return catogorylist;
        }
        public Catogory getID(int id)
        {
            if (catogorylist == null) { return null; }
            return catogorylist.Find(c => c.Id == id);
        }
        public bool AddBooks(Catogory catogory)
        {
            catogorylist.Add(catogory);
            return true;
        }
        public bool Remove(int id)
        {
            int index = catogorylist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                catogorylist.Remove(catogorylist.Find(x => x.Id == id));
                return true;
            }
            return false;
        }
        public bool UpDate(int id, Catogory catogory)
        {
            int index = catogorylist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                catogorylist.Insert(index, catogory);
                return true;
            }
            return false;
        }
    }
}
