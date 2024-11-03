using Microsoft.AspNetCore.Mvc;
using Project_libary.Entities;
using Project_libary.Servies;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_libary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        static Bookservies listofbooks = new Bookservies();
        // GET: api/<BookController>
        [HttpGet]
     
         public ActionResult<List<Book>> Get()
         { 
                List<Book> result = listofbooks.GetLists();
                if (result == null) { 
                    return  Unauthorized(); ;
                }
                return result;
         }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            if (id == null) { return Unauthorized(); }
            Book result = listofbooks.getID(id);
            if (result == null) { return Unauthorized(); }
            return (result);
        }

        // POST api/<BookController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Book value)
        {
            if(value == null) { return Unauthorized(); }
            
            bool result = listofbooks.AddBooks(value);
           return Ok(result);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Book book)
        {
            if (book == null||id<0) { return Unauthorized(); }
            bool result= listofbooks.UpDate(id, book);
            return Ok(result);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
           
            bool result=listofbooks.Remove(id);
            return Ok(result);

        }
    }
}
