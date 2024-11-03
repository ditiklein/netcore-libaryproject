using Project_libary.Entities;
using System.Collections.Generic;
using System.Text.Json;

namespace Project_libary.Servies
{
    public class Bookservies
    {

        public  List<Book> booklist { get; set; }
        public Bookservies()
        {
            booklist = new List<Book>() {new Book(1,"MalasCat","ditiklein",100,0, new DateTime(),2,4),
            new Book(2,"mally","racheliklein",1,200, new DateTime(),1,10)};
        }
        public List<Book> GetLists()
        {
            
            return booklist;
        }
        public Book getID(int id)
        {
            if (booklist == null) { return null; }
            return booklist.Find(c => c.Id == id);
        }
        public bool AddBooks(Book book)
        {
            booklist.Add(book);
            return true;
        }
        public bool Remove(int id)
        {
            int index = booklist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                booklist.Remove(booklist.Find(x => x.Id == id));
                return true;
            }
            return false;
        }
        public bool UpDate(int id, Book book)
        {
            int index = booklist.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                booklist.Insert(index, book);
                return true;
            }
            return false;
        }
    }
}
