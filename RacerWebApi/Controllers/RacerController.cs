using RacerWebApi.Model;
using RacerWebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using RacerWebApi.Model;

namespace RacerWebApi.Controllers
{
    public class RacerController
    {

    }
     // For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
     namespace EmployeeWebAPI.Controllers
     {
        [Route("api/[controller]")]
        [ApiController]
        public class RacerController : ControllerBase
        {  
            RacerRepository repository = new RacerRepository();
            // GET: api/<RacerController>
            [HttpGet]
            public List<Racer> Get()
            {
                return repository.GetRacers();
            }

            // GET api/<RacerController>/5
            [HttpGet("{id}")]
            public string Get(int id)
            {
                return "value";
            }

            // POST api/<RacerController>
            [HttpPost]
            public void Post([FromBody] string value)
            {
            }

            // PUT api/<RacerController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/<RacerController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {

            }
        }
     }
   
  
}
