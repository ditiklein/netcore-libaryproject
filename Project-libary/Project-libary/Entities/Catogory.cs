namespace Project_libary.Entities
{
    public class Catogory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool SuitableForChildren { get; set; }
        public bool SuitableForTeenager { get; set; }
        public bool SuitableForAdult { get; set; }

        public Catogory(int id, string name, bool suitableForChildren, bool suitableForTeenager, bool suitableForAdult)
        {
            Id = id;
            Name = name;
            SuitableForChildren = suitableForChildren;
            SuitableForTeenager = suitableForTeenager;
            SuitableForAdult = suitableForAdult;
        }

        public Catogory()
        {
        }
    }


}
