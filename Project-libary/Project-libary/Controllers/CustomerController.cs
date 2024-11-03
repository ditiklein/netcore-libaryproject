using Microsoft.AspNetCore.Mvc;
using Project_libary.Entities;
using Project_libary.Servies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_libary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
       static CustomerServies listofcustomer = new CustomerServies();
        // GET: api/<CustomerController>
        [HttpGet]

        public ActionResult<List<Customer>> Get()
        {
            List<Customer> result = listofcustomer.GetLists();
            if (result == null)
            {
                return Unauthorized(); ;
            }
            return result;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> GetById(int id)
        {
            if (id == null) { return Unauthorized(); }
            Customer result = listofcustomer.getID(id);
            if (result == null) { return Unauthorized(); }
            return (result);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Customer customer)
        {
            bool result = listofcustomer.AddBooks(customer);
            return Ok(result);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Customer customer)
        {
            bool result = listofcustomer.UpDate(id, customer);
            return Ok(result);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool result = listofcustomer.Remove(id);
            return Ok(result);

        }
    }
}
