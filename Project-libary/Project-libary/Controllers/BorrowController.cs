using Microsoft.AspNetCore.Mvc;
using Project_libary.Entities;
using Project_libary.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_libary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {

        static Borrowservies listofborrows = new Borrowservies();
        // GET: api/<BorrowController>
        [HttpGet]

        public ActionResult<List<Borrow>> Get()
        {
            List<Borrow> result = listofborrows.GetLists();
            if (result == null)
            {
                return Unauthorized(); ;
            }
            return result;
        }

        // GET api/<BorrowController>/5
        [HttpGet("{id}")]
        public ActionResult<Borrow> GetById(int id)
        {
            if (id == null) { return Unauthorized(); }
            Borrow result = listofborrows.getID(id);
            if (result == null) { return Unauthorized(); }
            return (result);
        }

        // POST api/<BorrowController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Borrow value)
        {
            bool result = listofborrows.AddBorrow(value);
            return Ok(result);
        }

        // PUT api/<BorrowController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Borrow borrow)
        {
            bool result = listofborrows.UpDate(id, borrow);
            return Ok(result);
        }

        // DELETE api/<BorrowController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool result = listofborrows.Remove(id);
            return Ok(result);

        }

    }
}
