using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace RacerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Welcome()
        {
            return "Welcome To the Web API";
        }
        [HttpGet("display")]
        public string Display()
        {
            return "Hello World";
        }
    }
}
