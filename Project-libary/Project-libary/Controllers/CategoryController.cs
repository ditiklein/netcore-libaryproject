using Microsoft.AspNetCore.Mvc;
using Project_libary.Entities;
using Project_libary.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_libary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

       static Catogoryservies listofcatogory = new Catogoryservies();
        // GET: api/<CatogoryController>
        [HttpGet]

        public ActionResult<List<Catogory>> Get()
        {
            List<Catogory> result = listofcatogory.GetLists();
            if (result == null)
            {
                return Unauthorized(); ;
            }
            return result;
        }

        // GET api/<CatogoryController>/5
        [HttpGet("{id}")]
        public ActionResult<Catogory> GetById(int id)
        {
            if (id == null) { return Unauthorized(); }
            Catogory result = listofcatogory.getID(id);
            if (result == null) { return Unauthorized(); }
            return (result);
        }

        // POST api/<CatogoryController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Catogory value)
        {
            bool result = listofcatogory.AddBooks(value);
            return Ok(result);
        }

        // PUT api/<CatogoryController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Catogory catogory)
        {
            bool result = listofcatogory.UpDate(id, catogory);
            return Ok(result);
        }

        // DELETE api/<CatogoryController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool result = listofcatogory.Remove(id);
            return Ok(result);

        }
    }
}
