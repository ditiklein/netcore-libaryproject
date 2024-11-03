using Microsoft.AspNetCore.Mvc;
using Project_libary.Entities;
using Project_libary.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_libary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {

        static Detailsservies listofdetails = new Detailsservies();
        // GET: api/<DetailsController>
        [HttpGet]

        public ActionResult<List<Details>> Get()
        {
            List<Details> result = listofdetails.GetLists();
            if (result == null)
            {
                return Unauthorized(); ;
            }
            return result;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public ActionResult<Details> GetById(int id)
        {
            if (id == null) { return Unauthorized(); }
            Details result = listofdetails.getID(id);
            if (result == null) { return Unauthorized(); }
            return (result);
        }

        // POST api/<BookController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Details details)
        {
            bool result = listofdetails.AddBooks(details);
            return Ok(result);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Details details)
        {
            bool result = listofdetails.UpDate(id, details);
            return Ok(result);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool result = listofdetails.Remove(id);
            return Ok(result);

        }
    }
}
